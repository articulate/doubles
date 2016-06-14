using System.Diagnostics;

namespace System.Threading
{
    public sealed class EventWaitHandleWrapper : IWaitHandle
    {
        private readonly EventWaitHandle eventWaitHandle;

        public EventWaitHandleWrapper(EventWaitHandle eventWaitHandle)
        {
            this.eventWaitHandle = eventWaitHandle;
        }

        public void Dispose()
        {
            eventWaitHandle.Dispose();
        }

        public void Wait()
        {
            if (!eventWaitHandle.WaitOne())
            {
                Debug.Fail("Failed to WaitOne() on EventWaitHandle!");
            }
        }

        public bool Wait(TimeSpan timeout)
        {
            return eventWaitHandle.WaitOne(timeout);
        }

        public void Set()
        {
            if (!eventWaitHandle.Set())
            {
                Debug.Fail("Failed to Set() EventWaitHandle!");
            }
        }
    }
}