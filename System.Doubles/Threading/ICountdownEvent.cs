namespace System.Threading
{
    public interface ICountdownEvent : IDisposable
    {
        int CurrentCount
        {
            get;
        }

        bool IsSet
        {
            get;
        }

        void AddCount();

        void Reset();

        bool Signal();

        void Wait();
    }
}