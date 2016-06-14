namespace System.Windows.Threading
{
    public interface IDispatcher
    {
        void Invoke(Action callback);

        TResult Invoke<TResult>(Func<TResult> callback);

        void InvokeShutdown();
    }
}