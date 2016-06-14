namespace System.Windows.Forms
{
    public interface IControl : IDisposable
    {
        string Name
        {
            get;
        }

        string AccessibleName
        {
            get;
        }

        bool Enabled
        {
            get;
            set;
        }

        bool InvokeRequired
        {
            get;
        }

        bool Focus();

        void BringToFront();

        object Invoke(Delegate method);

        object Invoke(Delegate method, params object[] args);

        IAsyncResult BeginInvoke(Delegate method);

        Form FindForm();
    }
}