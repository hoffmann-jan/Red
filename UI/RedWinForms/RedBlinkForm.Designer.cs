namespace JanHoffmann.Red.UI.RedWinForms
{
    partial class RedBlinkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedBlinkForm));
            this.lbl_RedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_RedLabel
            // 
            resources.ApplyResources(this.lbl_RedLabel, "lbl_RedLabel");
            this.lbl_RedLabel.BackColor = System.Drawing.Color.Red;
            this.lbl_RedLabel.Name = "lbl_RedLabel";
            this.lbl_RedLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbl_RedLabel_MouseDown);
            // 
            // RedBlink
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_RedLabel);
            this.Name = "RedBlink";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_RedLabel;
    }
}

