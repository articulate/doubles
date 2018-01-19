namespace System.Windows.Forms
{
    public interface INotifyIcon : IDisposable
    {
        event MouseEventHandler MouseClick;
        event EventHandler BalloonTipClicked;
        event EventHandler BalloonTipClosed;

        bool Visible
        {
            get;
            set;
        }

        ContextMenu ContextMenu
        {
            get;
            set;
        }

        NotifyIcon WrappedNotifyIcon
        {
            get;
        }

        void ShowBalloonTip(int timeout, string tipTitle, string tipText, ToolTipIcon tipIcon);
    }
}