namespace TickTalker
{
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.cbxOnTheHour = new System.Windows.Forms.CheckBox();
            this.cbxOnTheHalfHour = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudMinsInAdvance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxWarnInAdvance = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPlaySample = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trbSpeakingRate = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxQuietEndMeridiem = new System.Windows.Forms.ComboBox();
            this.nudQuietEnd = new System.Windows.Forms.NumericUpDown();
            this.cbxQuietStartMeridiem = new System.Windows.Forms.ComboBox();
            this.nudQuietStart = new System.Windows.Forms.NumericUpDown();
            this.chkQuietTime = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinsInAdvance)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeakingRate)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuietEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuietStart)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxOnTheHour
            // 
            this.cbxOnTheHour.AutoSize = true;
            this.cbxOnTheHour.Location = new System.Drawing.Point(9, 29);
            this.cbxOnTheHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxOnTheHour.Name = "cbxOnTheHour";
            this.cbxOnTheHour.Size = new System.Drawing.Size(160, 32);
            this.cbxOnTheHour.TabIndex = 1;
            this.cbxOnTheHour.Text = "On the hour";
            this.cbxOnTheHour.UseVisualStyleBackColor = true;
            // 
            // cbxOnTheHalfHour
            // 
            this.cbxOnTheHalfHour.AutoSize = true;
            this.cbxOnTheHalfHour.Location = new System.Drawing.Point(9, 72);
            this.cbxOnTheHalfHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxOnTheHalfHour.Name = "cbxOnTheHalfHour";
            this.cbxOnTheHalfHour.Size = new System.Drawing.Size(204, 32);
            this.cbxOnTheHalfHour.TabIndex = 2;
            this.cbxOnTheHalfHour.Text = "On the half hour";
            this.cbxOnTheHalfHour.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudMinsInAdvance);
            this.groupBox1.Controls.Add(this.cbxOnTheHour);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxOnTheHalfHour);
            this.groupBox1.Controls.Add(this.cbxWarnInAdvance);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(528, 178);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Announce";
            // 
            // nudMinsInAdvance
            // 
            this.nudMinsInAdvance.Location = new System.Drawing.Point(98, 109);
            this.nudMinsInAdvance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMinsInAdvance.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMinsInAdvance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinsInAdvance.Name = "nudMinsInAdvance";
            this.nudMinsInAdvance.Size = new System.Drawing.Size(64, 35);
            this.nudMinsInAdvance.TabIndex = 4;
            this.nudMinsInAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinsInAdvance.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "minutes in advance";
            // 
            // cbxWarnInAdvance
            // 
            this.cbxWarnInAdvance.AutoSize = true;
            this.cbxWarnInAdvance.Location = new System.Drawing.Point(9, 115);
            this.cbxWarnInAdvance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxWarnInAdvance.Name = "cbxWarnInAdvance";
            this.cbxWarnInAdvance.Size = new System.Drawing.Size(92, 32);
            this.cbxWarnInAdvance.TabIndex = 1;
            this.cbxWarnInAdvance.Text = "Warn";
            this.cbxWarnInAdvance.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(423, 505);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(124, 51);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPlaySample);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.trbSpeakingRate);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 208);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(528, 118);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Voice Options";
            // 
            // btnPlaySample
            // 
            this.btnPlaySample.Location = new System.Drawing.Point(374, 28);
            this.btnPlaySample.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlaySample.Name = "btnPlaySample";
            this.btnPlaySample.Size = new System.Drawing.Size(146, 54);
            this.btnPlaySample.TabIndex = 2;
            this.btnPlaySample.Text = "Play Sample";
            this.btnPlaySample.UseVisualStyleBackColor = true;
            this.btnPlaySample.Click += new System.EventHandler(this.btnPlaySample_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speaking Rate";
            // 
            // trbSpeakingRate
            // 
            this.trbSpeakingRate.Location = new System.Drawing.Point(168, 28);
            this.trbSpeakingRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trbSpeakingRate.Minimum = -10;
            this.trbSpeakingRate.Name = "trbSpeakingRate";
            this.trbSpeakingRate.Size = new System.Drawing.Size(196, 69);
            this.trbSpeakingRate.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxQuietEndMeridiem);
            this.groupBox2.Controls.Add(this.nudQuietEnd);
            this.groupBox2.Controls.Add(this.cbxQuietStartMeridiem);
            this.groupBox2.Controls.Add(this.nudQuietStart);
            this.groupBox2.Controls.Add(this.chkQuietTime);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 335);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(528, 160);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quiet Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "and";
            // 
            // cbxQuietEndMeridiem
            // 
            this.cbxQuietEndMeridiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuietEndMeridiem.FormattingEnabled = true;
            this.cbxQuietEndMeridiem.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbxQuietEndMeridiem.Location = new System.Drawing.Point(334, 85);
            this.cbxQuietEndMeridiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxQuietEndMeridiem.Name = "cbxQuietEndMeridiem";
            this.cbxQuietEndMeridiem.Size = new System.Drawing.Size(70, 36);
            this.cbxQuietEndMeridiem.TabIndex = 4;
            // 
            // nudQuietEnd
            // 
            this.nudQuietEnd.Location = new System.Drawing.Point(262, 86);
            this.nudQuietEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudQuietEnd.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudQuietEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuietEnd.Name = "nudQuietEnd";
            this.nudQuietEnd.Size = new System.Drawing.Size(63, 35);
            this.nudQuietEnd.TabIndex = 3;
            this.nudQuietEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxQuietStartMeridiem
            // 
            this.cbxQuietStartMeridiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuietStartMeridiem.FormattingEnabled = true;
            this.cbxQuietStartMeridiem.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbxQuietStartMeridiem.Location = new System.Drawing.Point(129, 83);
            this.cbxQuietStartMeridiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxQuietStartMeridiem.Name = "cbxQuietStartMeridiem";
            this.cbxQuietStartMeridiem.Size = new System.Drawing.Size(70, 36);
            this.cbxQuietStartMeridiem.TabIndex = 2;
            // 
            // nudQuietStart
            // 
            this.nudQuietStart.Location = new System.Drawing.Point(57, 85);
            this.nudQuietStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudQuietStart.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudQuietStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuietStart.Name = "nudQuietStart";
            this.nudQuietStart.Size = new System.Drawing.Size(63, 35);
            this.nudQuietStart.TabIndex = 1;
            this.nudQuietStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkQuietTime
            // 
            this.chkQuietTime.AutoSize = true;
            this.chkQuietTime.Location = new System.Drawing.Point(14, 40);
            this.chkQuietTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkQuietTime.Name = "chkQuietTime";
            this.chkQuietTime.Size = new System.Drawing.Size(424, 32);
            this.chkQuietTime.TabIndex = 0;
            this.chkQuietTime.Text = "Disable time announcements between";
            this.chkQuietTime.UseVisualStyleBackColor = true;
            this.chkQuietTime.CheckStateChanged += new System.EventHandler(this.chkQuietTime_CheckStateChanged);
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(566, 575);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TickTalker Settings";
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinsInAdvance)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeakingRate)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuietEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuietStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxOnTheHour;
        private System.Windows.Forms.CheckBox cbxOnTheHalfHour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxWarnInAdvance;
        private System.Windows.Forms.NumericUpDown nudMinsInAdvance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPlaySample;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trbSpeakingRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkQuietTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxQuietEndMeridiem;
        private System.Windows.Forms.NumericUpDown nudQuietEnd;
        private System.Windows.Forms.ComboBox cbxQuietStartMeridiem;
        private System.Windows.Forms.NumericUpDown nudQuietStart;

    }
}