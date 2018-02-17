using System.Threading;

namespace System.Windows.Threading
{
    public sealed class ManualResetEventWrapper : IManualResetEvent
    {
        private readonly ManualResetEvent manualResetEvent;

        public ManualResetEventWrapper(bool initialState)
        {
            manualResetEvent = new ManualResetEvent(initialState);
        }

        public void Dispose()
        {
            manualResetEvent.Dispose();
        }

        public void Set()
        {
            manualResetEvent.Set();
        }

        public bool Reset()
        {
            return manualResetEvent.Reset();
        }

        public bool WaitOne()
        {
            return manualResetEvent.WaitOne();
        }
    }
}