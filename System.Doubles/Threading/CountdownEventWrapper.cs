namespace System.Threading
{
    internal sealed class CountdownEventWrapper : ICountdownEvent
    {
        public int CurrentCount => countdownEvent.CurrentCount;

        public bool IsSet => countdownEvent.IsSet;

        private readonly CountdownEvent countdownEvent;

        public CountdownEventWrapper(int initialCount)
        {
            countdownEvent = new CountdownEvent(initialCount);
        }

        public void Dispose()
        {
            countdownEvent.Dispose();
        }

        public void AddCount()
        {
            countdownEvent.AddCount();
        }

        public void Reset()
        {
            countdownEvent.Reset();
        }

        public bool Signal()
        {
            return countdownEvent.Signal();
        }

        public void Wait()
        {
            countdownEvent.Wait();
        }
    }
}