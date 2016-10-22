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
            Process.Start("http://zinkolabs.com");
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version " + Globals.Version;
        }

        private void linkLabel2_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://gusperez.com/wp/about");
        }
    }
}
