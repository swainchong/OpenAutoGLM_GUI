using SharpAdbClient;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

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
    }
}
