namespace System.Diagnostics
{
    internal sealed class ProcessWrapper : IProcess
    {
        public event DataReceivedEventHandler OutputDataReceived
        {
            add
            {
                process.OutputDataReceived += value;
            }
            remove
            {
                process.OutputDataReceived -= value;
            }
        }

        public event DataReceivedEventHandler ErrorDataReceived
        {
            add
            {
                process.ErrorDataReceived += value;
            }
            remove
            {
                process.ErrorDataReceived -= value;
            }
        }

        public int ExitCode => process.ExitCode;

        public IProcessModule MainModule => mainModule.Value;

        public bool HasExited => process.HasExited;

        private readonly Lazy<IProcessModule> mainModule;

        private readonly Process process;

        public ProcessWrapper(Process process)
        {
            this.process = process;

            mainModule = new Lazy<IProcessModule>(() => new ProcessModuleWrapper(process.MainModule));
        }

        public void Dispose()
        {
            process.Dispose();
        }

        public bool Start()
        {
            return process.Start();
        }

        public void WaitForExit()
        {
            process.WaitForExit();
        }

        public void Kill()
        {
            process.Kill();
        }

        public void BeginOutputReadLine()
        {
            process.BeginOutputReadLine();
        }

        public void BeginErrorReadLine()
        {
            process.BeginErrorReadLine();
        }
    }
}