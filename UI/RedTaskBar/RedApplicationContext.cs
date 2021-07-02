using System;
using System.Drawing;

namespace RedTaskBar
{
    class RedApplicationContext : TrayIconApplicationContext
    {
        public RedApplicationContext()
        {
            TrayIcon.Icon = Properties.Resources.tray_ico;

            ContextMenu.Items.Add("&Settings...", null, SettingsContextMenuClickHandler).Font = new Font(this.ContextMenu.Font, FontStyle.Bold);
            ContextMenu.Items.Add("-");
            ContextMenu.Items.Add("&About...", null, AboutContextMenuClickHandler);
            ContextMenu.Items.Add("-");
            ContextMenu.Items.Add("E&xit", null, ExitContextMenuClickHandler);
        }

        protected override void OnTrayIconDoubleClick(EventArgs e)
        {
            ShowSettings();

            base.OnTrayIconDoubleClick(e);
        }

        private void AboutContextMenuClickHandler(object sender, EventArgs eventArgs)
        {
            //using (Form dialog = new AboutDialog())
            //    dialog.ShowDialog();
        }

        private void ExitContextMenuClickHandler(object sender, EventArgs eventArgs)
        {
            ExitThread();
        }

        private void SettingsContextMenuClickHandler(object sender, EventArgs eventArgs)
        {
            ShowSettings();
        }

        private void ShowSettings()
        {
            //using (Form dialog = new SettingsDialog())
            //    dialog.ShowDialog();
        }
    }
}
