namespace Mail
{
    partial class Settings
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
            this.groupBoxSmtp = new System.Windows.Forms.GroupBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.groupBoxEmail = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMailBox = new System.Windows.Forms.Label();
            this.textBoxMailBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelGmailCom = new System.Windows.Forms.Label();
            this.checkBoxSSl = new System.Windows.Forms.CheckBox();
            this.groupBoxSmtp.SuspendLayout();
            this.groupBoxEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSmtp
            // 
            this.groupBoxSmtp.Controls.Add(this.checkBoxSSl);
            this.groupBoxSmtp.Controls.Add(this.textBoxPort);
            this.groupBoxSmtp.Controls.Add(this.labelPort);
            this.groupBoxSmtp.Controls.Add(this.textBoxServer);
            this.groupBoxSmtp.Controls.Add(this.labelServer);
            this.groupBoxSmtp.Location = new System.Drawing.Point(12, 13);
            this.groupBoxSmtp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSmtp.Name = "groupBoxSmtp";
            this.groupBoxSmtp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSmtp.Size = new System.Drawing.Size(420, 95);
            this.groupBoxSmtp.TabIndex = 0;
            this.groupBoxSmtp.TabStop = false;
            this.groupBoxSmtp.Text = "Smtp";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(6, 25);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(54, 21);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Server";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(66, 22);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(348, 28);
            this.textBoxServer.TabIndex = 1;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(6, 59);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(40, 21);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "Port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(66, 56);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(290, 28);
            this.textBoxPort.TabIndex = 3;
            // 
            // groupBoxEmail
            // 
            this.groupBoxEmail.Controls.Add(this.labelGmailCom);
            this.groupBoxEmail.Controls.Add(this.textBoxName);
            this.groupBoxEmail.Controls.Add(this.labelName);
            this.groupBoxEmail.Controls.Add(this.labelMailBox);
            this.groupBoxEmail.Controls.Add(this.textBoxMailBox);
            this.groupBoxEmail.Controls.Add(this.textBoxPassword);
            this.groupBoxEmail.Controls.Add(this.labelPassword);
            this.groupBoxEmail.Controls.Add(this.textBoxEmail);
            this.groupBoxEmail.Controls.Add(this.label2);
            this.groupBoxEmail.Location = new System.Drawing.Point(12, 116);
            this.groupBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxEmail.Name = "groupBoxEmail";
            this.groupBoxEmail.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxEmail.Size = new System.Drawing.Size(420, 162);
            this.groupBoxEmail.TabIndex = 4;
            this.groupBoxEmail.TabStop = false;
            this.groupBoxEmail.Text = "Email";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(89, 90);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(325, 28);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 93);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 21);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(89, 56);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(230, 28);
            this.textBoxEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // labelMailBox
            // 
            this.labelMailBox.AutoSize = true;
            this.labelMailBox.Location = new System.Drawing.Point(6, 127);
            this.labelMailBox.Name = "labelMailBox";
            this.labelMailBox.Size = new System.Drawing.Size(66, 21);
            this.labelMailBox.TabIndex = 4;
            this.labelMailBox.Text = "MailBox";
            // 
            // textBoxMailBox
            // 
            this.textBoxMailBox.Location = new System.Drawing.Point(89, 124);
            this.textBoxMailBox.Name = "textBoxMailBox";
            this.textBoxMailBox.Size = new System.Drawing.Size(325, 28);
            this.textBoxMailBox.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 285);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(420, 35);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 21);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(89, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(325, 28);
            this.textBoxName.TabIndex = 6;
            // 
            // labelGmailCom
            // 
            this.labelGmailCom.AutoSize = true;
            this.labelGmailCom.Location = new System.Drawing.Point(317, 59);
            this.labelGmailCom.Name = "labelGmailCom";
            this.labelGmailCom.Size = new System.Drawing.Size(97, 21);
            this.labelGmailCom.TabIndex = 3454;
            this.labelGmailCom.Text = "@gmail.com";
            // 
            // checkBoxSSl
            // 
            this.checkBoxSSl.AutoSize = true;
            this.checkBoxSSl.Location = new System.Drawing.Point(362, 58);
            this.checkBoxSSl.Name = "checkBoxSSl";
            this.checkBoxSSl.Size = new System.Drawing.Size(52, 25);
            this.checkBoxSSl.TabIndex = 4;
            this.checkBoxSSl.Text = "SSl";
            this.checkBoxSSl.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 332);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxEmail);
            this.Controls.Add(this.groupBoxSmtp);
            this.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Settings";
            this.Text = "Settings";
            this.groupBoxSmtp.ResumeLayout(false);
            this.groupBoxSmtp.PerformLayout();
            this.groupBoxEmail.ResumeLayout(false);
            this.groupBoxEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSmtp;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.GroupBox groupBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMailBox;
        private System.Windows.Forms.TextBox textBoxMailBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGmailCom;
        private System.Windows.Forms.CheckBox checkBoxSSl;
    }
}