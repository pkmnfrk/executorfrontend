namespace ExecutorFrontend
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtWorkDir = new System.Windows.Forms.TextBox();
            this.cmdChooseDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numDayCount = new System.Windows.Forms.NumericUpDown();
            this.cmdStart = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.chkNightMode = new System.Windows.Forms.CheckBox();
            this.numStartHour = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numEndHour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numNightCount = new System.Windows.Forms.NumericUpDown();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.chkShowWindows = new System.Windows.Forms.CheckBox();
            this.chkRestartStuck = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numStuckTimeout = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDayCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNightCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStuckTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Command:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Working &Dir:";
            // 
            // txtCommand
            // 
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.Location = new System.Drawing.Point(85, 38);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(508, 20);
            this.txtCommand.TabIndex = 2;
            this.txtCommand.TextChanged += new System.EventHandler(this.txtCommand_TextChanged);
            // 
            // txtWorkDir
            // 
            this.txtWorkDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkDir.Location = new System.Drawing.Point(85, 64);
            this.txtWorkDir.Name = "txtWorkDir";
            this.txtWorkDir.Size = new System.Drawing.Size(427, 20);
            this.txtWorkDir.TabIndex = 2;
            this.txtWorkDir.TextChanged += new System.EventHandler(this.txtWorkDir_TextChanged);
            // 
            // cmdChooseDir
            // 
            this.cmdChooseDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdChooseDir.Location = new System.Drawing.Point(518, 62);
            this.cmdChooseDir.Name = "cmdChooseDir";
            this.cmdChooseDir.Size = new System.Drawing.Size(75, 23);
            this.cmdChooseDir.TabIndex = 3;
            this.cmdChooseDir.Text = "...";
            this.cmdChooseDir.UseVisualStyleBackColor = true;
            this.cmdChooseDir.Click += new System.EventHandler(this.cmdChooseDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Instances:";
            // 
            // numDayCount
            // 
            this.numDayCount.Location = new System.Drawing.Point(85, 90);
            this.numDayCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDayCount.Name = "numDayCount";
            this.numDayCount.Size = new System.Drawing.Size(63, 20);
            this.numDayCount.TabIndex = 5;
            this.numDayCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDayCount.ValueChanged += new System.EventHandler(this.numDayCount_ValueChanged);
            // 
            // cmdStart
            // 
            this.cmdStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStart.Location = new System.Drawing.Point(12, 217);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(581, 56);
            this.cmdStart.TabIndex = 6;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 279);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(581, 170);
            this.txtLog.TabIndex = 7;
            // 
            // chkNightMode
            // 
            this.chkNightMode.AutoSize = true;
            this.chkNightMode.Location = new System.Drawing.Point(17, 152);
            this.chkNightMode.Name = "chkNightMode";
            this.chkNightMode.Size = new System.Drawing.Size(117, 17);
            this.chkNightMode.TabIndex = 8;
            this.chkNightMode.Text = "Enable Night Mode";
            this.chkNightMode.UseVisualStyleBackColor = true;
            this.chkNightMode.CheckedChanged += new System.EventHandler(this.chkNightMode_CheckedChanged);
            // 
            // numStartHour
            // 
            this.numStartHour.Location = new System.Drawing.Point(85, 175);
            this.numStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numStartHour.Name = "numStartHour";
            this.numStartHour.Size = new System.Drawing.Size(49, 20);
            this.numStartHour.TabIndex = 9;
            this.numStartHour.ValueChanged += new System.EventHandler(this.numStartHour_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Between:";
            // 
            // numEndHour
            // 
            this.numEndHour.Location = new System.Drawing.Point(189, 175);
            this.numEndHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numEndHour.Name = "numEndHour";
            this.numEndHour.Size = new System.Drawing.Size(49, 20);
            this.numEndHour.TabIndex = 11;
            this.numEndHour.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numEndHour.ValueChanged += new System.EventHandler(this.numEndHour_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = ":00 and";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = ":00, have this many instances:";
            // 
            // numNightCount
            // 
            this.numNightCount.Location = new System.Drawing.Point(394, 175);
            this.numNightCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNightCount.Name = "numNightCount";
            this.numNightCount.Size = new System.Drawing.Size(62, 20);
            this.numNightCount.TabIndex = 14;
            this.numNightCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNightCount.ValueChanged += new System.EventHandler(this.numNightCount_ValueChanged);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 60000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // chkShowWindows
            // 
            this.chkShowWindows.AutoSize = true;
            this.chkShowWindows.Location = new System.Drawing.Point(166, 91);
            this.chkShowWindows.Name = "chkShowWindows";
            this.chkShowWindows.Size = new System.Drawing.Size(100, 17);
            this.chkShowWindows.TabIndex = 15;
            this.chkShowWindows.Text = "Show Windows";
            this.chkShowWindows.UseVisualStyleBackColor = true;
            this.chkShowWindows.CheckedChanged += new System.EventHandler(this.chkShowWindows_CheckedChanged);
            // 
            // chkRestartStuck
            // 
            this.chkRestartStuck.AutoSize = true;
            this.chkRestartStuck.Location = new System.Drawing.Point(313, 92);
            this.chkRestartStuck.Name = "chkRestartStuck";
            this.chkRestartStuck.Size = new System.Drawing.Size(175, 17);
            this.chkRestartStuck.TabIndex = 16;
            this.chkRestartStuck.Text = "Restart stuck processes** after:";
            this.toolTip1.SetToolTip(this.chkRestartStuck, "** only works for Portal 2");
            this.chkRestartStuck.UseVisualStyleBackColor = true;
            this.chkRestartStuck.CheckedChanged += new System.EventHandler(this.chkRestartStuck_CheckedChanged);
            // 
            // numStuckTimeout
            // 
            this.numStuckTimeout.Location = new System.Drawing.Point(485, 92);
            this.numStuckTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStuckTimeout.Name = "numStuckTimeout";
            this.numStuckTimeout.Size = new System.Drawing.Size(49, 20);
            this.numStuckTimeout.TabIndex = 17;
            this.numStuckTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStuckTimeout.ValueChanged += new System.EventHandler(this.numStuckTimeout_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "&Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(85, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(508, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numStuckTimeout);
            this.Controls.Add(this.chkRestartStuck);
            this.Controls.Add(this.chkShowWindows);
            this.Controls.Add(this.numNightCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numEndHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numStartHour);
            this.Controls.Add(this.chkNightMode);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.numDayCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdChooseDir);
            this.Controls.Add(this.txtWorkDir);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(480, 350);
            this.Name = "Form1";
            this.Text = "Command Executor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDayCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNightCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStuckTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtWorkDir;
        private System.Windows.Forms.Button cmdChooseDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDayCount;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.CheckBox chkNightMode;
        private System.Windows.Forms.NumericUpDown numStartHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numEndHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numNightCount;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.CheckBox chkShowWindows;
        private System.Windows.Forms.CheckBox chkRestartStuck;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numStuckTimeout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsername;
    }
}

