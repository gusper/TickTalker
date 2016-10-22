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
    public partial class SettingsDialog : Form
    {
        private SpeechSynthesizer _ss;

        public SettingsDialog(SpeechSynthesizer ss)
        {
            InitializeComponent();
            _ss = ss;
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            cbxOnTheHour.Checked = Settings.AnnounceOnTheHour;
            cbxOnTheHalfHour.Checked = Settings.AnnounceOnTheHalfHour;
            cbxWarnInAdvance.Checked = Settings.WarnInAdvance;
            nudMinsInAdvance.Value = Settings.MinutesInAdvance;
            trbSpeakingRate.Value = Settings.SpeakingRate;

            chkQuietTime.Checked = Settings.QuietTimeEnabled;
            setQuietSectionEnabledState(chkQuietTime.Checked);

            if (Settings.QuietStartHour > 12)
            {
                cbxQuietStartMeridiem.SelectedItem = "PM";
                nudQuietStart.Value = Settings.QuietStartHour - 12;
            }
            else
            {
                cbxQuietStartMeridiem.SelectedItem = "AM";
                nudQuietStart.Value = (Settings.QuietStartHour == 0) ? 12 : Settings.QuietStartHour;
            }

            if (Settings.QuietEndHour > 12)
            {
                cbxQuietEndMeridiem.SelectedItem = "PM";
                nudQuietEnd.Value = Settings.QuietEndHour - 12;
            }
            else
            {
                cbxQuietEndMeridiem.SelectedItem = "AM";
                nudQuietEnd.Value = (Settings.QuietEndHour == 0) ? 12 : Settings.QuietEndHour;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Settings.AnnounceOnTheHour = cbxOnTheHour.Checked;
            Settings.AnnounceOnTheHalfHour = cbxOnTheHalfHour.Checked;
            Settings.WarnInAdvance = cbxWarnInAdvance.Checked;
            Settings.MinutesInAdvance = (int)nudMinsInAdvance.Value;
            Settings.SpeakingRate = trbSpeakingRate.Value;

            Settings.QuietTimeEnabled = chkQuietTime.Checked;

            if (cbxQuietStartMeridiem.SelectedItem.ToString() == "PM")
            {
                // If it's Noon, then return 12, if it's after Noon, then add 12 to number
                Settings.QuietStartHour = (nudQuietStart.Value == 12m) ? 12 : (int)nudQuietStart.Value + 12;
            }
            else
            {
                Settings.QuietStartHour = (nudQuietStart.Value == 12m) ? 0 : (int)nudQuietStart.Value;
            }

            if (cbxQuietEndMeridiem.SelectedItem.ToString() == "PM")
            {
                // If it's Noon, then return 12, if it's after Noon, then add 12 to number
                Settings.QuietEndHour = (nudQuietEnd.Value == 12m) ? 12 : (int)nudQuietEnd.Value + 12;
            }
            else
            {
                Settings.QuietEndHour = (nudQuietEnd.Value == 12m) ? 0 : (int)nudQuietEnd.Value;
            }

            Settings.Save();
        }

        private void btnPlaySample_Click(object sender, EventArgs e)
        {
            _ss.Rate = trbSpeakingRate.Value;
            _ss.SpeakAsync("It's " + DateTime.Now.ToShortTimeString());
        }

        private void setQuietSectionEnabledState(bool state)
        {
            nudQuietStart.Enabled = state;
            nudQuietEnd.Enabled = state;
            cbxQuietStartMeridiem.Enabled = state;
            cbxQuietEndMeridiem.Enabled = state;
        }

        private void chkQuietTime_CheckStateChanged(object sender, EventArgs e)
        {
            setQuietSectionEnabledState(chkQuietTime.Checked);
        }
    }
}
