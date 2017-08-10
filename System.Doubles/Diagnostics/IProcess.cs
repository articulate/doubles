namespace System.Diagnostics
{
    public interface IProcess : IDisposable
    {
        event DataReceivedEventHandler OutputDataReceived;

        event DataReceivedEventHandler ErrorDataReceived;

        int ExitCode
        {
            get;
        }

        IProcessModule MainModule
        {
            get;
        }

        bool HasExited
        {
            get;
        }

        bool Start();

        void WaitForExit();

        void Kill();

        void BeginOutputReadLine();

        void BeginErrorReadLine();
    }
}