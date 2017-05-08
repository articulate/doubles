using System.Windows.Threading;

namespace System.Windows
{
    public sealed class ApplicationWrapper : IApplication
    {
        public event DispatcherUnhandledExceptionEventHandler DispatcherUnhandledException
        {
            add
            {
                Application.Current.DispatcherUnhandledException += value;
            }
            remove
            {
                Application.Current.DispatcherUnhandledException -= value;
            }
        }

        public Window MainWindow => Application.Current.MainWindow;

        public void Shutdown(int exitCode)
        {
            Application.Current.Shutdown(exitCode);
        }
    }
}