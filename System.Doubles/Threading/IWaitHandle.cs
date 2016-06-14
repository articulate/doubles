namespace System.Threading
{
    public interface IWaitHandle : IDisposable
    {
        void Wait();

        bool Wait(TimeSpan timeout);

        void Set();
    }
}