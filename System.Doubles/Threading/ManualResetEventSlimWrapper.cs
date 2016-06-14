namespace System.Threading
{
    public sealed class ManualResetEventSlimWrapper : IWaitHandle
    {
        private readonly ManualResetEventSlim manualResetEventSlim;

        public ManualResetEventSlimWrapper(ManualResetEventSlim manualResetEventSlim)
        {
            this.manualResetEventSlim = manualResetEventSlim;
        }

        public void Dispose()
        {
            manualResetEventSlim.Dispose();
        }

        public void Wait()
        {
            manualResetEventSlim.Wait();
        }

        public bool Wait(TimeSpan timeout)
        {
            return manualResetEventSlim.Wait(timeout);
        }

        public void Set()
        {
            manualResetEventSlim.Set();
        }
    }
}