namespace System.Windows.Threading
{
    public interface IDispatcher
    {
        bool CheckAccess();

        DispatcherOperation BeginInvoke(Delegate method, params object[] args);

        void Invoke(Action callback);

        TResult Invoke<TResult>(Func<TResult> callback);

        void InvokeShutdown();
    }
}