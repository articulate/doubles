namespace System.Diagnostics
{
    public interface IProcess : IDisposable
    {
        int ExitCode
        {
            get;
        }

        bool Start();

        void WaitForExit();

        void Kill();
    }
}