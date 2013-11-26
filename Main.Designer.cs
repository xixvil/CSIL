namespace Computer_Skin_Interface
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAmplitude = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAmplitude = new System.Windows.Forms.TrackBar();
            this.lbFrequency = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFrequency = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btSend = new System.Windows.Forms.Button();
            this.rbAsync = new System.Windows.Forms.RadioButton();
            this.rbSync = new System.Windows.Forms.RadioButton();
            this.udDuration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbSine = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFrequency)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udDuration)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAmplitude);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbAmplitude);
            this.groupBox1.Controls.Add(this.lbFrequency);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbFrequency);
            this.groupBox1.Location = new System.Drawing.Point(9, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters control";
            // 
            // lbAmplitude
            // 
            this.lbAmplitude.AutoSize = true;
            this.lbAmplitude.Location = new System.Drawing.Point(557, 85);
            this.lbAmplitude.Name = "lbAmplitude";
            this.lbAmplitude.Size = new System.Drawing.Size(22, 13);
            this.lbAmplitude.TabIndex = 6;
            this.lbAmplitude.Text = "0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amplitude";
            // 
            // tbAmplitude
            // 
            this.tbAmplitude.Location = new System.Drawing.Point(99, 76);
            this.tbAmplitude.Maximum = 100;
            this.tbAmplitude.Name = "tbAmplitude";
            this.tbAmplitude.Size = new System.Drawing.Size(452, 42);
            this.tbAmplitude.TabIndex = 4;
            this.tbAmplitude.TickFrequency = 2;
            this.tbAmplitude.Value = 10;
            this.tbAmplitude.ValueChanged += new System.EventHandler(this.tbAmplitude_ValueChanged);
            // 
            // lbFrequency
            // 
            this.lbFrequency.AutoSize = true;
            this.lbFrequency.Location = new System.Drawing.Point(557, 37);
            this.lbFrequency.Name = "lbFrequency";
            this.lbFrequency.Size = new System.Drawing.Size(41, 13);
            this.lbFrequency.TabIndex = 3;
            this.lbFrequency.Text = "200 Hz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frequency";
            // 
            // tbFrequency
            // 
            this.tbFrequency.Location = new System.Drawing.Point(99, 28);
            this.tbFrequency.Maximum = 1000;
            this.tbFrequency.Minimum = 1;
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.Size = new System.Drawing.Size(452, 42);
            this.tbFrequency.TabIndex = 0;
            this.tbFrequency.TickFrequency = 20;
            this.tbFrequency.Value = 200;
            this.tbFrequency.ValueChanged += new System.EventHandler(this.tbFrequency_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btStop);
            this.groupBox2.Controls.Add(this.btStart);
            this.groupBox2.Controls.Add(this.cbDevice);
            this.groupBox2.Location = new System.Drawing.Point(9, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btSend);
            this.groupBox4.Controls.Add(this.rbAsync);
            this.groupBox4.Controls.Add(this.rbSync);
            this.groupBox4.Controls.Add(this.udDuration);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(6, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(622, 54);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Single signal";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(457, 19);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(147, 22);
            this.btSend.TabIndex = 4;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // rbAsync
            // 
            this.rbAsync.AutoSize = true;
            this.rbAsync.Location = new System.Drawing.Point(351, 25);
            this.rbAsync.Name = "rbAsync";
            this.rbAsync.Size = new System.Drawing.Size(92, 17);
            this.rbAsync.TabIndex = 3;
            this.rbAsync.Text = "Asynchronous";
            this.rbAsync.UseVisualStyleBackColor = true;
            // 
            // rbSync
            // 
            this.rbSync.AutoSize = true;
            this.rbSync.Checked = true;
            this.rbSync.Location = new System.Drawing.Point(253, 24);
            this.rbSync.Name = "rbSync";
            this.rbSync.Size = new System.Drawing.Size(87, 17);
            this.rbSync.TabIndex = 2;
            this.rbSync.TabStop = true;
            this.rbSync.Text = "Synchronous";
            this.rbSync.UseVisualStyleBackColor = true;
            // 
            // udDuration
            // 
            this.udDuration.Location = new System.Drawing.Point(159, 22);
            this.udDuration.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.udDuration.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.udDuration.Name = "udDuration";
            this.udDuration.Size = new System.Drawing.Size(76, 20);
            this.udDuration.TabIndex = 1;
            this.udDuration.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Signal duration (milliseconds):";
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(463, 19);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(148, 24);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(276, 19);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(148, 24);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // cbDevice
            // 
            this.cbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(14, 22);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(246, 21);
            this.cbDevice.TabIndex = 0;
            this.cbDevice.SelectedIndexChanged += new System.EventHandler(this.cbDevice_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.rbTriangle);
            this.groupBox3.Controls.Add(this.rbSquare);
            this.groupBox3.Controls.Add(this.rbSine);
            this.groupBox3.Location = new System.Drawing.Point(9, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 55);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select signal form";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(525, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(310, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(420, 22);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(92, 17);
            this.rbTriangle.TabIndex = 2;
            this.rbTriangle.Text = "Triangle wave";
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.CheckedChanged += new System.EventHandler(this.rbTriangle_CheckedChanged);
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(216, 22);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(88, 17);
            this.rbSquare.TabIndex = 1;
            this.rbSquare.Text = "Square wave";
            this.rbSquare.UseVisualStyleBackColor = true;
            this.rbSquare.CheckedChanged += new System.EventHandler(this.rbSquare_CheckedChanged);
            // 
            // rbSine
            // 
            this.rbSine.AutoSize = true;
            this.rbSine.Checked = true;
            this.rbSine.Location = new System.Drawing.Point(11, 22);
            this.rbSine.Name = "rbSine";
            this.rbSine.Size = new System.Drawing.Size(75, 17);
            this.rbSine.TabIndex = 0;
            this.rbSine.TabStop = true;
            this.rbSine.Text = "Sine wave";
            this.rbSine.UseVisualStyleBackColor = true;
            this.rbSine.CheckedChanged += new System.EventHandler(this.rbSine_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 330);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Computer-Skin Interface";
            this.Load += new System.EventHandler(this.Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFrequency)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udDuration)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbFrequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAmplitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbAmplitude;
        private System.Windows.Forms.Label lbFrequency;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown udDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAsync;
        private System.Windows.Forms.RadioButton rbSync;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbSine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

