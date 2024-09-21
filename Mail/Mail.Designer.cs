namespace Mail
{
    partial class Mail
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smtpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxThema = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.groupBoxTo = new System.Windows.Forms.GroupBox();
            this.labelGmailCom = new System.Windows.Forms.Label();
            this.groupBoxThema = new System.Windows.Forms.GroupBox();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBoxINBOX = new System.Windows.Forms.GroupBox();
            this.listBoxIn = new System.Windows.Forms.ListBox();
            this.labelIn = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.buttonReload = new System.Windows.Forms.Button();
            this.textBoxINBOX = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxMsgIndex = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxTo.SuspendLayout();
            this.groupBoxThema.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.groupBoxINBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(872, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smtpToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // smtpToolStripMenuItem
            // 
            this.smtpToolStripMenuItem.Name = "smtpToolStripMenuItem";
            this.smtpToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.smtpToolStripMenuItem.Text = "SMTP Settings";
            this.smtpToolStripMenuItem.Click += new System.EventHandler(this.smtpToolStripMenuItem_Click);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(6, 26);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(305, 28);
            this.textBoxTo.TabIndex = 0;
            // 
            // textBoxThema
            // 
            this.textBoxThema.Location = new System.Drawing.Point(6, 27);
            this.textBoxThema.Name = "textBoxThema";
            this.textBoxThema.Size = new System.Drawing.Size(408, 28);
            this.textBoxThema.TabIndex = 1;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(6, 27);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(408, 141);
            this.textBoxMessage.TabIndex = 3;
            // 
            // groupBoxTo
            // 
            this.groupBoxTo.Controls.Add(this.labelGmailCom);
            this.groupBoxTo.Controls.Add(this.textBoxTo);
            this.groupBoxTo.Location = new System.Drawing.Point(12, 32);
            this.groupBoxTo.Name = "groupBoxTo";
            this.groupBoxTo.Size = new System.Drawing.Size(420, 63);
            this.groupBoxTo.TabIndex = 456;
            this.groupBoxTo.TabStop = false;
            this.groupBoxTo.Text = "To";
            // 
            // labelGmailCom
            // 
            this.labelGmailCom.AutoSize = true;
            this.labelGmailCom.Location = new System.Drawing.Point(317, 29);
            this.labelGmailCom.Name = "labelGmailCom";
            this.labelGmailCom.Size = new System.Drawing.Size(97, 21);
            this.labelGmailCom.TabIndex = 3453;
            this.labelGmailCom.Text = "@gmail.com";
            // 
            // groupBoxThema
            // 
            this.groupBoxThema.Controls.Add(this.textBoxThema);
            this.groupBoxThema.Location = new System.Drawing.Point(12, 101);
            this.groupBoxThema.Name = "groupBoxThema";
            this.groupBoxThema.Size = new System.Drawing.Size(420, 63);
            this.groupBoxThema.TabIndex = 43522;
            this.groupBoxThema.TabStop = false;
            this.groupBoxThema.Text = "Thema (optional)";
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.textBoxMessage);
            this.groupBoxMessage.Location = new System.Drawing.Point(12, 170);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(420, 176);
            this.groupBoxMessage.TabIndex = 10123;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Message";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(12, 352);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(420, 35);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupBoxINBOX
            // 
            this.groupBoxINBOX.Controls.Add(this.listBoxIn);
            this.groupBoxINBOX.Controls.Add(this.labelIn);
            this.groupBoxINBOX.Controls.Add(this.textBoxFind);
            this.groupBoxINBOX.Controls.Add(this.labelFind);
            this.groupBoxINBOX.Controls.Add(this.buttonReload);
            this.groupBoxINBOX.Controls.Add(this.textBoxINBOX);
            this.groupBoxINBOX.Location = new System.Drawing.Point(438, 32);
            this.groupBoxINBOX.Name = "groupBoxINBOX";
            this.groupBoxINBOX.Size = new System.Drawing.Size(420, 314);
            this.groupBoxINBOX.TabIndex = 43523;
            this.groupBoxINBOX.TabStop = false;
            this.groupBoxINBOX.Text = "INBOX";
            // 
            // listBoxIn
            // 
            this.listBoxIn.FormattingEnabled = true;
            this.listBoxIn.ItemHeight = 21;
            this.listBoxIn.Items.AddRange(new object[] {
            "",
            "Body",
            "Thema",
            "Draft",
            "Unseen"});
            this.listBoxIn.Location = new System.Drawing.Point(233, 25);
            this.listBoxIn.Name = "listBoxIn";
            this.listBoxIn.Size = new System.Drawing.Size(90, 25);
            this.listBoxIn.TabIndex = 43526;
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Location = new System.Drawing.Point(200, 25);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(23, 21);
            this.labelIn.TabIndex = 43525;
            this.labelIn.Text = "in";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(52, 21);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(142, 28);
            this.textBoxFind.TabIndex = 3454;
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(6, 25);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(40, 21);
            this.labelFind.TabIndex = 3455;
            this.labelFind.Text = "Find";
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(329, 19);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(85, 31);
            this.buttonReload.TabIndex = 43524;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // textBoxINBOX
            // 
            this.textBoxINBOX.Location = new System.Drawing.Point(6, 56);
            this.textBoxINBOX.Multiline = true;
            this.textBoxINBOX.Name = "textBoxINBOX";
            this.textBoxINBOX.Size = new System.Drawing.Size(408, 250);
            this.textBoxINBOX.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(438, 352);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(347, 35);
            this.buttonDelete.TabIndex = 43524;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxMsgIndex
            // 
            this.listBoxMsgIndex.FormattingEnabled = true;
            this.listBoxMsgIndex.ItemHeight = 21;
            this.listBoxMsgIndex.Location = new System.Drawing.Point(791, 352);
            this.listBoxMsgIndex.Name = "listBoxMsgIndex";
            this.listBoxMsgIndex.Size = new System.Drawing.Size(61, 25);
            this.listBoxMsgIndex.TabIndex = 43527;
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 398);
            this.Controls.Add(this.listBoxMsgIndex);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBoxINBOX);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.groupBoxMessage);
            this.Controls.Add(this.groupBoxThema);
            this.Controls.Add(this.groupBoxTo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mail";
            this.Text = "Mail";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxTo.ResumeLayout(false);
            this.groupBoxTo.PerformLayout();
            this.groupBoxThema.ResumeLayout(false);
            this.groupBoxThema.PerformLayout();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.groupBoxINBOX.ResumeLayout(false);
            this.groupBoxINBOX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smtpToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxThema;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.GroupBox groupBoxTo;
        private System.Windows.Forms.GroupBox groupBoxThema;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelGmailCom;
        private System.Windows.Forms.GroupBox groupBoxINBOX;
        private System.Windows.Forms.TextBox textBoxINBOX;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.ListBox listBoxIn;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxMsgIndex;
    }
}

