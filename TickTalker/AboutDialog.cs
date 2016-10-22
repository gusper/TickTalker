using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TickTalker
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://gusperez.com/wp/software");
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version " + Globals.Version;
        }
    }
}
