namespace System.Diagnostics
{
    public interface IProcess : IDisposable
    {
        int ExitCode
        {
            get;
        }

        IntPtr MainWindowHandle
        {
            get;
        }

        bool Start();

        void WaitForExit();

        void Kill();
    }
}