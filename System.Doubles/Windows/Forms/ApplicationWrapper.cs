using System.Threading;

namespace System.Windows.Forms
{
    public sealed class ApplicationWrapper : IApplication
    {
        public event ThreadExceptionEventHandler ThreadException
        {
            add
            {
                Application.ThreadException += value;
            }
            remove
            {
                Application.ThreadException -= value;
            }
        }

        public void Exit()
        {
            Application.Exit();
        }
    }
}