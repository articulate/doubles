namespace System.Diagnostics
{
    internal sealed class ProcessWrapper : IProcess
    {
        public int ExitCode => process.ExitCode;

        public IProcessModule MainModule => mainModule.Value;

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
    }
}