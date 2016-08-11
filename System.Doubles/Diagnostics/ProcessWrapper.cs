namespace System.Diagnostics
{
    internal sealed class ProcessWrapper : IProcess
    {
        public int ExitCode => process.ExitCode;

        public IntPtr MainWindowHandle => process.MainWindowHandle;

        private readonly Process process;

        public ProcessWrapper(Process process)
        {
            this.process = process;
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