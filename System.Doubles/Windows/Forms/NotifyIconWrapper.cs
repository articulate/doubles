using System.Drawing;

namespace System.Windows.Forms
{
    public sealed class NotifyIconWrapper : INotifyIcon
    {
        public event MouseEventHandler MouseClick
        {
            add
            {
                WrappedNotifyIcon.MouseClick += value;
            }
            remove
            {
                WrappedNotifyIcon.MouseClick -= value;
            }
        }

        public event EventHandler BalloonTipClicked
        {
            add
            {
                WrappedNotifyIcon.BalloonTipClicked += value;
            }
            remove
            {
                WrappedNotifyIcon.BalloonTipClicked -= value;
            }
        }

        public bool Visible
        {
            get
            {
                return WrappedNotifyIcon.Visible;
            }
            set
            {
                WrappedNotifyIcon.Visible = value;
            }
        }

        public ContextMenu ContextMenu
        {
            get
            {
                return WrappedNotifyIcon.ContextMenu;
            }
            set
            {
                WrappedNotifyIcon.ContextMenu = value;
            }
        }

        public NotifyIcon WrappedNotifyIcon
        {
            get;
        }

        public NotifyIconWrapper(string notifyText, Icon icon)
        {
            WrappedNotifyIcon = new NotifyIcon
            {
                Text    = notifyText,
                Icon    = icon,
                Visible = true
            };
        }

        public void Dispose()
        {
            WrappedNotifyIcon.Dispose();
        }

        public void ShowBalloonTip(int timeout, string tipTitle, string tipText, ToolTipIcon tipIcon)
        {
            WrappedNotifyIcon.ShowBalloonTip(timeout, tipTitle, tipText, tipIcon);
        }
    }
}