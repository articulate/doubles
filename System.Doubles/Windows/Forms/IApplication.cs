using System.Threading;

namespace System.Windows.Forms
{
    public interface IApplication
    {
        event ThreadExceptionEventHandler ThreadException;

        void Exit();
    }
}