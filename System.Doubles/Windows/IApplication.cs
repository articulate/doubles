using System.Windows.Threading;

namespace System.Windows
{
    public interface IApplication
    {
        event DispatcherUnhandledExceptionEventHandler DispatcherUnhandledException;

        Window MainWindow
        {
            get;
        }
    }
}