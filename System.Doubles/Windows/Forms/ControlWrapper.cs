namespace System.Windows.Forms
{
    public sealed class ControlWrapper : IControl
    {
        public string Name => WrappedControl.Name;

        public string AccessibleName => WrappedControl.AccessibleName;

        public bool Enabled
        {
            get
            {
                return WrappedControl.Enabled;
            }
            set
            {
                WrappedControl.Enabled = value;
            }
        }

        public bool InvokeRequired => WrappedControl.InvokeRequired;

        public Control WrappedControl
        {
            get;
        }

        public ControlWrapper(Control control)
        {
            WrappedControl = control;
        }

        public void Dispose()
        {
            WrappedControl.Dispose();
        }

        public bool Focus()
        {
            return WrappedControl.Focus();
        }

        public void BringToFront()
        {
            WrappedControl.BringToFront();
        }

        public object Invoke(Delegate method)
        {
            return WrappedControl.Invoke(method);
        }

        public object Invoke(Delegate method, params object[] args)
        {
            return WrappedControl.Invoke(method, args);
        }

        public IAsyncResult BeginInvoke(Delegate method)
        {
            return WrappedControl.BeginInvoke(method);
        }

        public Form FindForm()
        {
            return WrappedControl.FindForm();
        }
    }
}