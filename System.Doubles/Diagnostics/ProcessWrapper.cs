using System.IO;

namespace System.Diagnostics
{
    internal sealed class ProcessWrapper : IProcess
    {
        public event DataReceivedEventHandler OutputDataReceived
        {
            add => process.OutputDataReceived += value;
            remove => process.OutputDataReceived -= value;
        }

        public event DataReceivedEventHandler ErrorDataReceived
        {
            add => process.ErrorDataReceived += value;
            remove => process.ErrorDataReceived -= value;
        }

        public int ExitCode => process.ExitCode;

        public IProcessModule MainModule => mainModule.Value;

        public bool HasExited => process.HasExited;

        public IStreamReader StandardOutput => standardOutput.Value;

        public IStreamReader StandardError => standardError.Value;

        private readonly Lazy<IProcessModule> mainModule;
        private readonly Lazy<IStreamReader> standardOutput;
        private readonly Lazy<IStreamReader> standardError;

        private readonly Process process;

        public ProcessWrapper(Process process)
        {
            this.process = process;

            mainModule = new Lazy<IProcessModule>(() => new ProcessModuleWrapper(process.MainModule));
            standardOutput = new Lazy<IStreamReader>(() => new StreamReaderWrapper(process.StandardOutput));
            standardError = new Lazy<IStreamReader>(() => new StreamReaderWrapper(process.StandardError));
        }

        public void Dispose() => process.Dispose();

        public bool Start() => process.Start();

        public void WaitForExit() => process.WaitForExit();

        public void Kill() => process.Kill();

        public void BeginOutputReadLine() => process.BeginOutputReadLine();

        public void BeginErrorReadLine() => process.BeginErrorReadLine();
    }
}