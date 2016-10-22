using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TickTalker
{
    public partial class MainForm : Form
    {
        private Talker _talker = new Talker();

        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Minimized;
            BringToFront();
        }

        private void showSettingsDialog()
        {
            var sd = new SettingsDialog(_talker.SynthObj);
            sd.ShowDialog();
        }

        private void cmsSettings_Click(object sender, EventArgs e)
        {
            showSettingsDialog();
        }

        private void cmsExit_Click(object sender, EventArgs e)
        {
            nicTray.Visible = false;
            Application.Exit();
        }

        private void aboutTickTalkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutDialog().ShowDialog();
        }

        private void timeClock_Tick(object sender, EventArgs e)
        {
            _talker.ProcessTick();
        }
    }
}
