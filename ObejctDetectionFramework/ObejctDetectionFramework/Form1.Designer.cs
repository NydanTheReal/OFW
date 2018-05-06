namespace ObejctDetectionFramework
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lstPackets = new System.Windows.Forms.ListBox();
            this.btnWindows = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lstCircles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trcMin = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trcMax = new System.Windows.Forms.TrackBar();
            this.chbRaw = new System.Windows.Forms.CheckBox();
            this.chbHSV = new System.Windows.Forms.CheckBox();
            this.chbEdited = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trcMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcMax)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(244, 25);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(244, 68);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "7777";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStatus.Location = new System.Drawing.Point(244, 95);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status: Not sending";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(247, 112);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(247, 141);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop send";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lstPackets
            // 
            this.lstPackets.FormattingEnabled = true;
            this.lstPackets.Location = new System.Drawing.Point(247, 170);
            this.lstPackets.Name = "lstPackets";
            this.lstPackets.Size = new System.Drawing.Size(243, 95);
            this.lstPackets.TabIndex = 7;
            // 
            // btnWindows
            // 
            this.btnWindows.Location = new System.Drawing.Point(12, 141);
            this.btnWindows.Name = "btnWindows";
            this.btnWindows.Size = new System.Drawing.Size(107, 23);
            this.btnWindows.TabIndex = 8;
            this.btnWindows.Text = "Create Windows";
            this.btnWindows.UseVisualStyleBackColor = true;
            this.btnWindows.Click += new System.EventHandler(this.btnWindows_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(12, 169);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLoop.Size = new System.Drawing.Size(75, 23);
            this.btnLoop.TabIndex = 9;
            this.btnLoop.Text = "Start Loop";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(12, 198);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 10;
            this.btnEnd.Text = "End Loop";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lstCircles
            // 
            this.lstCircles.FormattingEnabled = true;
            this.lstCircles.Location = new System.Drawing.Point(12, 239);
            this.lstCircles.Name = "lstCircles";
            this.lstCircles.Size = new System.Drawing.Size(208, 95);
            this.lstCircles.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "OpenCV:";
            // 
            // trcMin
            // 
            this.trcMin.AutoSize = false;
            this.trcMin.Location = new System.Drawing.Point(70, 25);
            this.trcMin.Maximum = 100;
            this.trcMin.Name = "trcMin";
            this.trcMin.Size = new System.Drawing.Size(104, 35);
            this.trcMin.TabIndex = 13;
            this.trcMin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcMin.Value = 30;
            this.trcMin.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Min. Radius:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(181, 31);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(19, 13);
            this.lblMin.TabIndex = 15;
            this.lblMin.Text = "30";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(181, 62);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(19, 13);
            this.lblMax.TabIndex = 18;
            this.lblMax.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(9, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Max. Radius:";
            // 
            // trcMax
            // 
            this.trcMax.AutoSize = false;
            this.trcMax.Location = new System.Drawing.Point(70, 56);
            this.trcMax.Maximum = 100;
            this.trcMax.Name = "trcMax";
            this.trcMax.Size = new System.Drawing.Size(104, 35);
            this.trcMax.TabIndex = 16;
            this.trcMax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcMax.Value = 50;
            this.trcMax.Scroll += new System.EventHandler(this.trcMax_Scroll);
            // 
            // chbRaw
            // 
            this.chbRaw.AutoSize = true;
            this.chbRaw.Location = new System.Drawing.Point(13, 91);
            this.chbRaw.Name = "chbRaw";
            this.chbRaw.Size = new System.Drawing.Size(48, 17);
            this.chbRaw.TabIndex = 19;
            this.chbRaw.Text = "Raw";
            this.chbRaw.UseVisualStyleBackColor = true;
            // 
            // chbHSV
            // 
            this.chbHSV.AutoSize = true;
            this.chbHSV.Checked = true;
            this.chbHSV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbHSV.Location = new System.Drawing.Point(98, 91);
            this.chbHSV.Name = "chbHSV";
            this.chbHSV.Size = new System.Drawing.Size(48, 17);
            this.chbHSV.TabIndex = 20;
            this.chbHSV.Text = "HSV";
            this.chbHSV.UseVisualStyleBackColor = true;
            // 
            // chbEdited
            // 
            this.chbEdited.AutoSize = true;
            this.chbEdited.Checked = true;
            this.chbEdited.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbEdited.Location = new System.Drawing.Point(13, 112);
            this.chbEdited.Name = "chbEdited";
            this.chbEdited.Size = new System.Drawing.Size(56, 17);
            this.chbEdited.TabIndex = 21;
            this.chbEdited.Text = "Edited";
            this.chbEdited.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 356);
            this.Controls.Add(this.chbEdited);
            this.Controls.Add(this.chbHSV);
            this.Controls.Add(this.chbRaw);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trcMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trcMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCircles);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.btnWindows);
            this.Controls.Add(this.lstPackets);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Object Detection";
            ((System.ComponentModel.ISupportInitialize)(this.trcMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lstPackets;
        private System.Windows.Forms.Button btnWindows;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ListBox lstCircles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trcMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trcMax;
        private System.Windows.Forms.CheckBox chbRaw;
        private System.Windows.Forms.CheckBox chbHSV;
        private System.Windows.Forms.CheckBox chbEdited;
    }
}

