namespace AutoScan
{
    partial class Adjust
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
            this.faultlist = new System.Windows.Forms.ListBox();
            this.fault = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cropIm = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropIm)).BeginInit();
            this.SuspendLayout();
            // 
            // faultlist
            // 
            this.faultlist.FormattingEnabled = true;
            this.faultlist.ItemHeight = 16;
            this.faultlist.Location = new System.Drawing.Point(48, 115);
            this.faultlist.Name = "faultlist";
            this.faultlist.Size = new System.Drawing.Size(257, 292);
            this.faultlist.TabIndex = 0;
            this.faultlist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.faultlist_MouseClick);
            this.faultlist.SelectedIndexChanged += new System.EventHandler(this.faultlist_SelectedIndexChanged);
            // 
            // fault
            // 
            this.fault.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fault.Location = new System.Drawing.Point(359, 115);
            this.fault.Name = "fault";
            this.fault.Size = new System.Drawing.Size(657, 468);
            this.fault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fault.TabIndex = 1;
            this.fault.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Düzelt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 3;
            // 
            // cropIm
            // 
            this.cropIm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cropIm.Location = new System.Drawing.Point(48, 414);
            this.cropIm.Name = "cropIm";
            this.cropIm.Size = new System.Drawing.Size(257, 169);
            this.cropIm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cropIm.TabIndex = 4;
            this.cropIm.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(785, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(820, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Adjust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 595);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cropIm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fault);
            this.Controls.Add(this.faultlist);
            this.Name = "Adjust";
            this.Text = "Adjust";
            this.Load += new System.EventHandler(this.Adjust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropIm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox faultlist;
        private System.Windows.Forms.PictureBox fault;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox cropIm;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}