namespace UploadingHelper
{
    partial class Upload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload));
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.pnlUpload = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.cbPrivacyStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTags = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVideoPath = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayListId = new System.Windows.Forms.TextBox();
            this.pnlUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.White;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(361, 415);
            this.rtbLog.TabIndex = 35;
            this.rtbLog.Text = "";
            // 
            // pnlUpload
            // 
            this.pnlUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpload.Controls.Add(this.label1);
            this.pnlUpload.Controls.Add(this.txtPlayListId);
            this.pnlUpload.Controls.Add(this.txtDescription);
            this.pnlUpload.Controls.Add(this.cbPrivacyStatus);
            this.pnlUpload.Controls.Add(this.label7);
            this.pnlUpload.Controls.Add(this.label6);
            this.pnlUpload.Controls.Add(this.label5);
            this.pnlUpload.Controls.Add(this.lblTags);
            this.pnlUpload.Controls.Add(this.label3);
            this.pnlUpload.Controls.Add(this.label8);
            this.pnlUpload.Controls.Add(this.txtVideoPath);
            this.pnlUpload.Controls.Add(this.txtCategoryId);
            this.pnlUpload.Controls.Add(this.txtTags);
            this.pnlUpload.Controls.Add(this.txtTitle);
            this.pnlUpload.Controls.Add(this.lblFileName);
            this.pnlUpload.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUpload.Location = new System.Drawing.Point(361, 0);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(473, 415);
            this.pnlUpload.TabIndex = 36;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(76, 54);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(384, 225);
            this.txtDescription.TabIndex = 28;
            this.txtDescription.Text = "";
            // 
            // cbPrivacyStatus
            // 
            this.cbPrivacyStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrivacyStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPrivacyStatus.FormattingEnabled = true;
            this.cbPrivacyStatus.Items.AddRange(new object[] {
            "public",
            "private",
            "unlisted"});
            this.cbPrivacyStatus.Location = new System.Drawing.Point(76, 336);
            this.cbPrivacyStatus.Name = "cbPrivacyStatus";
            this.cbPrivacyStatus.Size = new System.Drawing.Size(384, 21);
            this.cbPrivacyStatus.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Video Path:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "PrivacyStatus:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "CategoryId:";
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(38, 288);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(34, 13);
            this.lblTags.TabIndex = 23;
            this.lblTags.Text = "Tags:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Title:";
            // 
            // txtVideoPath
            // 
            this.txtVideoPath.BackColor = System.Drawing.Color.White;
            this.txtVideoPath.Location = new System.Drawing.Point(76, 363);
            this.txtVideoPath.MaxLength = 2147483647;
            this.txtVideoPath.Name = "txtVideoPath";
            this.txtVideoPath.ReadOnly = true;
            this.txtVideoPath.Size = new System.Drawing.Size(384, 20);
            this.txtVideoPath.TabIndex = 19;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.BackColor = System.Drawing.Color.White;
            this.txtCategoryId.Location = new System.Drawing.Point(76, 311);
            this.txtCategoryId.MaxLength = 2147483647;
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.ReadOnly = true;
            this.txtCategoryId.Size = new System.Drawing.Size(384, 20);
            this.txtCategoryId.TabIndex = 18;
            this.txtCategoryId.Text = "1";
            // 
            // txtTags
            // 
            this.txtTags.BackColor = System.Drawing.Color.White;
            this.txtTags.Location = new System.Drawing.Point(76, 285);
            this.txtTags.MaxLength = 2147483647;
            this.txtTags.Name = "txtTags";
            this.txtTags.ReadOnly = true;
            this.txtTags.Size = new System.Drawing.Size(384, 20);
            this.txtTags.TabIndex = 17;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(76, 28);
            this.txtTitle.MaxLength = 2147483647;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(384, 20);
            this.txtTitle.TabIndex = 15;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(192, 6);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(59, 13);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "PlayListId:";
            // 
            // txtPlayListId
            // 
            this.txtPlayListId.BackColor = System.Drawing.Color.White;
            this.txtPlayListId.Enabled = false;
            this.txtPlayListId.Location = new System.Drawing.Point(76, 389);
            this.txtPlayListId.MaxLength = 2147483647;
            this.txtPlayListId.Name = "txtPlayListId";
            this.txtPlayListId.ReadOnly = true;
            this.txtPlayListId.Size = new System.Drawing.Size(384, 20);
            this.txtPlayListId.TabIndex = 29;
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 415);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.pnlUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Upload";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Upload_FormClosing);
            this.Load += new System.EventHandler(this.Upload_Load);
            this.pnlUpload.ResumeLayout(false);
            this.pnlUpload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Panel pnlUpload;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.ComboBox cbPrivacyStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVideoPath;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayListId;
    }
}