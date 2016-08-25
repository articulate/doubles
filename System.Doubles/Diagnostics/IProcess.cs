namespace System.Diagnostics
{
    public interface IProcess : IDisposable
    {
        int ExitCode
        {
            get;
        }

        IProcessModule MainModule
        {
            get;
        }

        bool Start();

        void WaitForExit();

        void Kill();
    }
}