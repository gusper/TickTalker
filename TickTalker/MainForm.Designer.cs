namespace TickTalker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nicTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timeClock = new System.Windows.Forms.Timer(this.components);
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // nicTray
            // 
            this.nicTray.ContextMenuStrip = this.cmsMenu;
            this.nicTray.Icon = ((System.Drawing.Icon)(resources.GetObject("nicTray.Icon")));
            this.nicTray.Text = "TickTalker";
            this.nicTray.Visible = true;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSettings,
            this.toolStripMenuItem2,
            this.cmsAbout,
            this.toolStripMenuItem1,
            this.cmsExit});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(174, 82);
            // 
            // cmsSettings
            // 
            this.cmsSettings.Name = "cmsSettings";
            this.cmsSettings.Size = new System.Drawing.Size(173, 22);
            this.cmsSettings.Text = "Settings...";
            this.cmsSettings.Click += new System.EventHandler(this.cmsSettings_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(170, 6);
            // 
            // cmsAbout
            // 
            this.cmsAbout.Name = "cmsAbout";
            this.cmsAbout.Size = new System.Drawing.Size(173, 22);
            this.cmsAbout.Text = "&About TickTalker...";
            this.cmsAbout.Click += new System.EventHandler(this.aboutTickTalkerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // cmsExit
            // 
            this.cmsExit.Name = "cmsExit";
            this.cmsExit.Size = new System.Drawing.Size(173, 22);
            this.cmsExit.Text = "E&xit";
            this.cmsExit.Click += new System.EventHandler(this.cmsExit_Click);
            // 
            // timeClock
            // 
            this.timeClock.Enabled = true;
            this.timeClock.Interval = 60000;
            this.timeClock.Tick += new System.EventHandler(this.timeClock_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 333);
            this.ControlBox = false;
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TickTalker";
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nicTray;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsExit;
        private System.Windows.Forms.ToolStripMenuItem cmsSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cmsAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Timer timeClock;
    }
}

