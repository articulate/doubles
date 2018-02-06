namespace System.Windows.Threading
{
    internal interface IManualResetEvent : IDisposable
    {
        void Set();

        bool WaitOne();
    }
}