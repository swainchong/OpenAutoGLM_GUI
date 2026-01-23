using System;
using System.Diagnostics;
using System.Text;

namespace SB.Helper
{
    public class ProcessExec : IDisposable
    {
        private Process _process;
        private bool _isRunning;

        public bool IsRunning => _isRunning;

        // ===== 事件（给 UI 订阅）=====
        public event Action<string> OutputReceived;
        public event Action<string> ErrorReceived;
        public event Action ProcessExited;

        // ===== 启动 =====
        public void Start(
            string exePath,
            string arguments,
            string workingDirectory)
        {
            if (_isRunning)
                return;

            _process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = exePath,
                    Arguments = arguments,
                    WorkingDirectory = workingDirectory,

                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,

                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8
                },
                EnableRaisingEvents = true
            };

            _process.OutputDataReceived += (s, e) =>
            {
                if (e.Data != null)
                    OutputReceived?.Invoke(e.Data);
            };

            _process.ErrorDataReceived += (s, e) =>
            {
                if (e.Data != null)
                    ErrorReceived?.Invoke(e.Data);
            };

            _process.Exited += (s, e) =>
            {
                _isRunning = false;
                ProcessExited?.Invoke();
            };

            _process.Start();
            _process.BeginOutputReadLine();
            _process.BeginErrorReadLine();

            _isRunning = true;
        }

        // ===== 停止 =====
        public void Stop()
        {
            if (_process == null)
                return;

            try
            {
                if (!_process.HasExited)
                    _process.Kill();
            }
            catch { }

            _isRunning = false;
        }

        // ===== 清理 =====
        public void Dispose()
        {
            Stop();
            _process?.Dispose();
        }
    }
}
