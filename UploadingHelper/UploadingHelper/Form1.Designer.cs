namespace UploadingHelper
{
    partial class CrawlAndRender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrawlAndRender));
            this.tmCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.txtSoundLink = new System.Windows.Forms.TextBox();
            this.txtImageLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNextTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStrat = new System.Windows.Forms.Button();
            this.nmTimeDelay = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.lblCurentTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmTimeDelay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmCurrentTime
            // 
            this.tmCurrentTime.Interval = 1000;
            this.tmCurrentTime.Tick += new System.EventHandler(this.tmCurrentTime_Tick);
            // 
            // txtSoundLink
            // 
            this.txtSoundLink.BackColor = System.Drawing.Color.White;
            this.txtSoundLink.Location = new System.Drawing.Point(70, 29);
            this.txtSoundLink.MaxLength = 999999999;
            this.txtSoundLink.Name = "txtSoundLink";
            this.txtSoundLink.ReadOnly = true;
            this.txtSoundLink.Size = new System.Drawing.Size(356, 20);
            this.txtSoundLink.TabIndex = 15;
            // 
            // txtImageLink
            // 
            this.txtImageLink.BackColor = System.Drawing.Color.White;
            this.txtImageLink.Location = new System.Drawing.Point(70, 6);
            this.txtImageLink.MaxLength = 999999999;
            this.txtImageLink.Name = "txtImageLink";
            this.txtImageLink.ReadOnly = true;
            this.txtImageLink.Size = new System.Drawing.Size(356, 20);
            this.txtImageLink.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sound link:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image link:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current time:";
            // 
            // lblNextTime
            // 
            this.lblNextTime.AutoSize = true;
            this.lblNextTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNextTime.Location = new System.Drawing.Point(349, 357);
            this.lblNextTime.Name = "lblNextTime";
            this.lblNextTime.Size = new System.Drawing.Size(63, 24);
            this.lblNextTime.TabIndex = 7;
            this.lblNextTime.Text = "Empty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Count time:";
            // 
            // btnStrat
            // 
            this.btnStrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrat.Location = new System.Drawing.Point(3, 358);
            this.btnStrat.Name = "btnStrat";
            this.btnStrat.Size = new System.Drawing.Size(210, 23);
            this.btnStrat.TabIndex = 1;
            this.btnStrat.Text = "Start";
            this.btnStrat.UseVisualStyleBackColor = true;
            this.btnStrat.Click += new System.EventHandler(this.btnStrat_Click);
            // 
            // nmTimeDelay
            // 
            this.nmTimeDelay.Location = new System.Drawing.Point(3, 332);
            this.nmTimeDelay.Maximum = new decimal(new int[] {
            10080,
            0,
            0,
            0});
            this.nmTimeDelay.Name = "nmTimeDelay";
            this.nmTimeDelay.Size = new System.Drawing.Size(210, 20);
            this.nmTimeDelay.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nmTimeDelay);
            this.panel1.Controls.Add(this.lblNextTime);
            this.panel1.Controls.Add(this.txtSoundLink);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtImageLink);
            this.panel1.Controls.Add(this.btnStrat);
            this.panel1.Controls.Add(this.rtbLog);
            this.panel1.Controls.Add(this.lblCurentTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 388);
            this.panel1.TabIndex = 2;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(0, 55);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(434, 274);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // lblCurentTime
            // 
            this.lblCurentTime.AutoSize = true;
            this.lblCurentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCurentTime.Location = new System.Drawing.Point(349, 333);
            this.lblCurentTime.Name = "lblCurentTime";
            this.lblCurentTime.Size = new System.Drawing.Size(80, 24);
            this.lblCurentTime.TabIndex = 5;
            this.lblCurentTime.Text = "00:00:00";
            // 
            // CrawlAndRender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 388);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CrawlAndRender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrawlAndRender";
            ((System.ComponentModel.ISupportInitialize)(this.nmTimeDelay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmCurrentTime;
        private System.Windows.Forms.TextBox txtSoundLink;
        private System.Windows.Forms.TextBox txtImageLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNextTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStrat;
        private System.Windows.Forms.NumericUpDown nmTimeDelay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label lblCurentTime;
    }
}

