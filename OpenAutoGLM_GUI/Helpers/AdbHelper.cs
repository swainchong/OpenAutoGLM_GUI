using SharpAdbClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace OpenAutoGLM_GUI.Helpers
{
    public static class AdbHelper
    {
        /// <summary>
        /// 尝试连接指定 DnsEndPoint，并在超时前轮询设备列表以确认连接成功。
        /// </summary>
        public static async Task<bool> ConnectAsync(AdbClient adbClient, DnsEndPoint dnsEndPoint,
            TimeSpan timeOut, CancellationToken token, Action<string> log = null)
        {
            try
            {
                adbClient.Connect(dnsEndPoint);
            }
            catch (Exception ex)
            {
                log?.Invoke(ex.Message);
                return false;
            }

            var serial = $"{dnsEndPoint.Host}:{dnsEndPoint.Port}";
            var start = DateTime.Now;

            while (DateTime.Now - start < timeOut)
            {
                token.ThrowIfCancellationRequested();

                var devices = await Task.Run(() => adbClient.GetDevices(), token);

                if (devices.Any(d => d.Serial == serial))
                {
                    return true;
                }

                await Task.Delay(100, token);
            }

            log?.Invoke($"failed to connect {dnsEndPoint.Host}:{dnsEndPoint.Port}, check if device is reachable");
            return false;
        }
        public class DeviceStateChangedEventArgs : EventArgs
        {
            public DeviceData Device { get; }
            public DeviceState OldState { get; }
            public DeviceState NewState { get; }

            public DeviceStateChangedEventArgs(DeviceData device, DeviceState oldState, DeviceState newState)
            {
                Device = device;
                OldState = oldState;
                NewState = newState;
            }
        }
        public class DeviceStateWatcher : IDisposable
        {
            private readonly Dictionary<string, DeviceState> _lastStates = new Dictionary<string, DeviceState>();
            private readonly CancellationTokenSource _cts = new CancellationTokenSource();
            private readonly AdbClient _adb = new AdbClient();

            public event EventHandler<DeviceStateChangedEventArgs> DeviceStateChanged;

            public void Start()
            {
                Task.Run(PollLoop);
            }

            private async Task PollLoop()
            {
                while (!_cts.IsCancellationRequested)
                {
                    List<DeviceData> devices;

                    try
                    {
                        devices = _adb.GetDevices();
                    }
                    catch
                    {
                        await Task.Delay(300);
                        continue;
                    }

                    foreach (var device in devices)
                    {
                        if (_lastStates.TryGetValue(device.Serial, out var last))
                        {
                            if (last != device.State)
                            {
                                _lastStates[device.Serial] = device.State;
                                DeviceStateChanged?.Invoke(
                                    this,
                                    new DeviceStateChangedEventArgs(device, last, device.State)
                                );
                            }
                        }
                        else
                        {
                            _lastStates[device.Serial] = device.State;
                            DeviceStateChanged?.Invoke(
                                this,
                                new DeviceStateChangedEventArgs(device, DeviceState.Unknown, device.State)
                            );
                        }
                    }

                    // 处理被移除的设备
                    var currentSerials = devices.Select(d => d.Serial).ToHashSet();
                    foreach (var removed in _lastStates.Keys.Except(currentSerials).ToList())
                    {
                        var old = _lastStates[removed];
                        _lastStates.Remove(removed);
                    }

                    await Task.Delay(300);
                }
            }

            public void Dispose()
            {
                _cts.Cancel();
            }
        }

    }
}
