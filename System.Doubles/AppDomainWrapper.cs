namespace System
{
    public sealed class AppDomainWrapper : IAppDomain
    {
        public event UnhandledExceptionEventHandler UnhandledException
        {
            add
            {
                AppDomain.CurrentDomain.UnhandledException += value;
            }
            remove
            {
                AppDomain.CurrentDomain.UnhandledException -= value;
            }
        }
    }
}