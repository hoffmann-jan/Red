using System;
using System.Drawing;

namespace Red
{
    class RedApplicationContext : TrayIconApplicationContext
    {
        public RedApplicationContext()
        {
            //this.TrayIcon.Icon = Resources.SmallIcon;

            this.ContextMenu.Items.Add("&Settings...", null, this.SettingsContextMenuClickHandler).Font = new Font(this.ContextMenu.Font, FontStyle.Bold);
            this.ContextMenu.Items.Add("-");
            this.ContextMenu.Items.Add("&About...", null, this.AboutContextMenuClickHandler);
            this.ContextMenu.Items.Add("-");
            this.ContextMenu.Items.Add("E&xit", null, this.ExitContextMenuClickHandler);
        }

        protected override void OnTrayIconDoubleClick(EventArgs e)
        {
            this.ShowSettings();

            base.OnTrayIconDoubleClick(e);
        }

        private void AboutContextMenuClickHandler(object sender, EventArgs eventArgs)
        {
            //using (Form dialog = new AboutDialog())
            //    dialog.ShowDialog();
        }

        private void ExitContextMenuClickHandler(object sender, EventArgs eventArgs)
        {
            this.ExitThread();
        }

        private void SettingsContextMenuClickHandler(object sender, EventArgs eventArgs)
        {
            this.ShowSettings();
        }

        private void ShowSettings()
        {
            //using (Form dialog = new SettingsDialog())
            //    dialog.ShowDialog();
        }
    }
}
