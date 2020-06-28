namespace AutoScan
{
    partial class frmAutoScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoScan));
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.picScan = new System.Windows.Forms.PictureBox();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bgwScan = new System.ComponentModel.BackgroundWorker();
            this.pbWaiting = new System.Windows.Forms.ProgressBar();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.nudRes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHeightInch = new System.Windows.Forms.NumericUpDown();
            this.nudWidthInch = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCustomPixel = new System.Windows.Forms.CheckBox();
            this.cmbColorMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fatList = new System.Windows.Forms.ListBox();
            this.cropIm = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.erFat = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.adjust = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightInch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthInch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropIm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(264, 12);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(96, 36);
            this.btnSelectPath.TabIndex = 0;
            this.btnSelectPath.Text = "Select Path";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(24, 18);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(231, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(143, 71);
            this.btnStartScan.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(100, 28);
            this.btnStartScan.TabIndex = 2;
            this.btnStartScan.Text = "Start";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // btnStopScan
            // 
            this.btnStopScan.Enabled = false;
            this.btnStopScan.Location = new System.Drawing.Point(260, 71);
            this.btnStopScan.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(100, 28);
            this.btnStopScan.TabIndex = 3;
            this.btnStopScan.Text = "Stop";
            this.btnStopScan.UseVisualStyleBackColor = true;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // picScan
            // 
            this.picScan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picScan.Image = ((System.Drawing.Image)(resources.GetObject("picScan.Image")));
            this.picScan.InitialImage = global::AutoScan.Properties.Resources.LOGO;
            this.picScan.Location = new System.Drawing.Point(548, 172);
            this.picScan.Margin = new System.Windows.Forms.Padding(4);
            this.picScan.Name = "picScan";
            this.picScan.Size = new System.Drawing.Size(800, 500);
            this.picScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picScan.TabIndex = 4;
            this.picScan.TabStop = false;
            this.picScan.Click += new System.EventHandler(this.picScan_Click);
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(796, 89);
            this.nudWidth.Margin = new System.Windows.Forms.Padding(4);
            this.nudWidth.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.ReadOnly = true;
            this.nudWidth.Size = new System.Drawing.Size(87, 22);
            this.nudWidth.TabIndex = 10;
            this.nudWidth.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(891, 89);
            this.nudHeight.Margin = new System.Windows.Forms.Padding(4);
            this.nudHeight.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.ReadOnly = true;
            this.nudHeight.Size = new System.Drawing.Size(87, 22);
            this.nudHeight.TabIndex = 11;
            this.nudHeight.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(807, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Height";
            // 
            // bgwScan
            // 
            this.bgwScan.WorkerReportsProgress = true;
            this.bgwScan.WorkerSupportsCancellation = true;
            this.bgwScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwScan_DoWork);
            this.bgwScan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwScan_ProgressChanged);
            this.bgwScan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwScan_RunWorkerCompleted);
            // 
            // pbWaiting
            // 
            this.pbWaiting.Location = new System.Drawing.Point(32, 369);
            this.pbWaiting.Margin = new System.Windows.Forms.Padding(4);
            this.pbWaiting.Name = "pbWaiting";
            this.pbWaiting.Size = new System.Drawing.Size(349, 31);
            this.pbWaiting.TabIndex = 15;
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(396, 372);
            this.nudTime.Margin = new System.Windows.Forms.Padding(4);
            this.nudTime.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(65, 22);
            this.nudTime.TabIndex = 16;
            this.nudTime.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudRes
            // 
            this.nudRes.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudRes.Location = new System.Drawing.Point(896, 15);
            this.nudRes.Margin = new System.Windows.Forms.Padding(4);
            this.nudRes.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nudRes.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nudRes.Name = "nudRes";
            this.nudRes.Size = new System.Drawing.Size(87, 22);
            this.nudRes.TabIndex = 17;
            this.nudRes.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudRes.ValueChanged += new System.EventHandler(this.nudRes_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(901, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Resolution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Waiting Sec.";
            // 
            // nudHeightInch
            // 
            this.nudHeightInch.Location = new System.Drawing.Point(796, 15);
            this.nudHeightInch.Margin = new System.Windows.Forms.Padding(4);
            this.nudHeightInch.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudHeightInch.Name = "nudHeightInch";
            this.nudHeightInch.Size = new System.Drawing.Size(87, 22);
            this.nudHeightInch.TabIndex = 21;
            this.nudHeightInch.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudHeightInch.ValueChanged += new System.EventHandler(this.nudHeightInch_ValueChanged);
            // 
            // nudWidthInch
            // 
            this.nudWidthInch.Location = new System.Drawing.Point(693, 15);
            this.nudWidthInch.Margin = new System.Windows.Forms.Padding(4);
            this.nudWidthInch.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudWidthInch.Name = "nudWidthInch";
            this.nudWidthInch.Size = new System.Drawing.Size(87, 22);
            this.nudWidthInch.TabIndex = 20;
            this.nudWidthInch.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudWidthInch.ValueChanged += new System.EventHandler(this.nudWidthInch_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(797, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Pixel Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(892, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Pixel Height";
            // 
            // cbxCustomPixel
            // 
            this.cbxCustomPixel.AutoSize = true;
            this.cbxCustomPixel.Location = new System.Drawing.Point(629, 92);
            this.cbxCustomPixel.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCustomPixel.Name = "cbxCustomPixel";
            this.cbxCustomPixel.Size = new System.Drawing.Size(146, 21);
            this.cbxCustomPixel.TabIndex = 24;
            this.cbxCustomPixel.Text = "Custom Pixel Units";
            this.cbxCustomPixel.UseVisualStyleBackColor = true;
            this.cbxCustomPixel.CheckedChanged += new System.EventHandler(this.cbxCustomPixel_CheckedChanged);
            // 
            // cmbColorMode
            // 
            this.cmbColorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorMode.FormattingEnabled = true;
            this.cmbColorMode.Items.AddRange(new object[] {
            "Black and White",
            "Color",
            "Gray Scale"});
            this.cmbColorMode.Location = new System.Drawing.Point(500, 12);
            this.cmbColorMode.Margin = new System.Windows.Forms.Padding(4);
            this.cmbColorMode.Name = "cmbColorMode";
            this.cmbColorMode.Size = new System.Drawing.Size(176, 24);
            this.cmbColorMode.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Color Mode";
            // 
            // txtWT
            // 
            this.txtWT.BackColor = System.Drawing.Color.White;
            this.txtWT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWT.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWT.ForeColor = System.Drawing.Color.Chartreuse;
            this.txtWT.Location = new System.Drawing.Point(35, 416);
            this.txtWT.Margin = new System.Windows.Forms.Padding(4);
            this.txtWT.Name = "txtWT";
            this.txtWT.Size = new System.Drawing.Size(347, 36);
            this.txtWT.TabIndex = 27;
            this.txtWT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fatList
            // 
            this.fatList.FormattingEnabled = true;
            this.fatList.ItemHeight = 16;
            this.fatList.Location = new System.Drawing.Point(35, 172);
            this.fatList.Name = "fatList";
            this.fatList.Size = new System.Drawing.Size(131, 180);
            this.fatList.TabIndex = 30;
            this.fatList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fatList_MouseClick);
            this.fatList.SelectedIndexChanged += new System.EventHandler(this.fatList_SelectedIndexChanged);
            // 
            // cropIm
            // 
            this.cropIm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cropIm.Location = new System.Drawing.Point(35, 475);
            this.cropIm.Margin = new System.Windows.Forms.Padding(4);
            this.cropIm.Name = "cropIm";
            this.cropIm.Size = new System.Drawing.Size(437, 197);
            this.cropIm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cropIm.TabIndex = 31;
            this.cropIm.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 32;
            // 
            // erFat
            // 
            this.erFat.FormattingEnabled = true;
            this.erFat.ItemHeight = 16;
            this.erFat.Location = new System.Drawing.Point(207, 172);
            this.erFat.Name = "erFat";
            this.erFat.Size = new System.Drawing.Size(131, 180);
            this.erFat.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Kaydedilen Faturalar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Kaydedilemeyen Faturalar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "(0)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "(0)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1282, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "V 1.0.8";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 37);
            this.button2.TabIndex = 39;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adjust
            // 
            this.adjust.Location = new System.Drawing.Point(1116, 18);
            this.adjust.Name = "adjust";
            this.adjust.Size = new System.Drawing.Size(143, 68);
            this.adjust.TabIndex = 40;
            this.adjust.Text = "Kaydedilemeyen Faturaları Düzenle";
            this.adjust.UseVisualStyleBackColor = true;
            this.adjust.Click += new System.EventHandler(this.adjust_Click);
            // 
            // frmAutoScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1378, 701);
            this.Controls.Add(this.adjust);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.erFat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cropIm);
            this.Controls.Add(this.fatList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbColorMode);
            this.Controls.Add(this.cbxCustomPixel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudHeightInch);
            this.Controls.Add(this.nudWidthInch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudRes);
            this.Controls.Add(this.nudTime);
            this.Controls.Add(this.pbWaiting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.picScan);
            this.Controls.Add(this.btnStopScan);
            this.Controls.Add(this.btnStartScan);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnSelectPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAutoScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatic Scanner  - tiff format File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAutoScan_FormClosing);
            this.Load += new System.EventHandler(this.frmAutoScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightInch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthInch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropIm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.PictureBox picScan;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker bgwScan;
        private System.Windows.Forms.ProgressBar pbWaiting;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.NumericUpDown nudRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHeightInch;
        private System.Windows.Forms.NumericUpDown nudWidthInch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxCustomPixel;
        private System.Windows.Forms.ComboBox cmbColorMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox fatList;
        private System.Windows.Forms.PictureBox cropIm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button adjust;
        public System.Windows.Forms.ListBox erFat;
    }
}

