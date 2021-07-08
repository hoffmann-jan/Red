using System;
using System.Windows.Forms;

namespace JanHoffmann.Red.UI.RedTaskBar
{
    public abstract class TrayIconApplicationContext : ApplicationContext
    {
        private readonly ContextMenuStrip _contextMenu;
        private readonly NotifyIcon _notifyIcon;

        protected ContextMenuStrip ContextMenu => _contextMenu;
        protected NotifyIcon TrayIcon => _notifyIcon;

        protected TrayIconApplicationContext()
        {
            _contextMenu = new ContextMenuStrip();

            Application.ApplicationExit += ApplicationExitHandler;

            _notifyIcon = new NotifyIcon
            {
                ContextMenuStrip = _contextMenu,
                Text = Application.ProductName,
                Visible = true
            };

            TrayIcon.DoubleClick += TrayIconDoubleClickHandler;
            TrayIcon.Click += TrayIconClickHandler;
        }

        protected virtual void OnApplicationExit(EventArgs e)
        {
            if (_notifyIcon != null)
            {
                _notifyIcon.Visible = false;
                _notifyIcon.Dispose();
            }

            if (_contextMenu != null)
            {
                _contextMenu.Dispose();
            }
        }

        private void ApplicationExitHandler(object sender, EventArgs e)
        {
            OnApplicationExit(e);
        }

        protected virtual void OnTrayIconClick(EventArgs e)
        { }

        protected virtual void OnTrayIconDoubleClick(EventArgs e)
        { }

        private void TrayIconClickHandler(object sender, EventArgs e)
        {
            OnTrayIconClick(e);
        }

        private void TrayIconDoubleClickHandler(object sender, EventArgs e)
        {
            OnTrayIconDoubleClick(e);
        }
    }
}
