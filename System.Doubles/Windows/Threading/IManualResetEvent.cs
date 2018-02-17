namespace System.Windows.Threading
{
    public interface IManualResetEvent : IDisposable
    {
        void Set();

        bool Reset();

        bool WaitOne();
    }
}