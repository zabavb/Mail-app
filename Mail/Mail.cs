using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using AE.Net.Mail;
using MailMessage = System.Net.Mail.MailMessage;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Mail
{
    public partial class Mail : Form
    {
        private SettingsData SettingsData { get; set; }
        static ImapClient IC;
        public Mail()
        {
            InitializeComponent();
        }

        private void smtpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
            if (!settings.Data.IsError)
                SettingsData = settings.Data;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (SettingsData == null)
            {
                MessageBox.Show("Settings error. Please check your settings options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBoxTo.Text) || string.IsNullOrEmpty(textBoxMessage.Text))
            {
                MessageBox.Show("Receiver and message could not be empty. Please check fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(textBoxTo.Text) && !string.IsNullOrEmpty(textBoxMessage.Text) && SettingsData != null)
            {
                try
                {
                    using (MailMessage msg = new MailMessage(new MailAddress(SettingsData.Email, SettingsData.Name), new MailAddress($"{textBoxTo.Text}@gmail.com")))
                    {
                        msg.Subject = textBoxThema.Text;
                        msg.Body = textBoxMessage.Text;

                        using (SmtpClient smtp = new SmtpClient(SettingsData.Server, SettingsData.Port))
                        {
                            smtp.Credentials = new NetworkCredential(SettingsData.Email, SettingsData.Password);
                            smtp.EnableSsl = SettingsData.SSl;

                            smtp.Send(msg);
                            MessageBox.Show("Message delivered successfully!", "Delivered", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Receiver and message could not be empty. Please check fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            textBoxINBOX.Text = string.Empty;
            int countMsgs = 0;

            IC = new ImapClient("imap.gmail.com", SettingsData.Email, SettingsData.Password, AuthMethods.Login, 993, SettingsData.SSl);

            if (listBoxIn.SelectedIndex == 0)
            {
                var msgs = IC.GetMessages(0, IC.GetMessageCount(), false, false);
                foreach (var msg in msgs)
                {
                    textBoxINBOX.Text = msg.From.ToString() + "\n";
                    textBoxINBOX.Text = msg.Date.ToString() + "\n";
                    textBoxINBOX.Text = msg.Subject + "\n";
                    textBoxINBOX.Text = msg.Body + "\n";
                    textBoxINBOX.Text = "\n\n=============================\n\n";
                }
                if (string.IsNullOrEmpty(textBoxINBOX.Text))
                    textBoxINBOX.Text = "\tEmpty...";

                countMsgs = msgs.Length;
            }

            else if (!string.IsNullOrEmpty(textBoxFind.Text))
            {
                if (listBoxIn.SelectedIndex == 1)
                    countMsgs = Output(IC.SearchMessages(SearchCondition.Body(textBoxFind.Text)));
                else if (listBoxIn.SelectedIndex == 2)
                    countMsgs = Output(IC.SearchMessages(SearchCondition.Subject(textBoxFind.Text)));
            }

            else if (listBoxIn.SelectedIndex == 3)
                countMsgs = Output(IC.SearchMessages(SearchCondition.Draft()));
            else if (listBoxIn.SelectedIndex == 4)
                countMsgs = Output(IC.SearchMessages(SearchCondition.Unseen()));

            listBoxMsgIndex.Items.Clear();
            for (int i = 0; i < countMsgs; i++)
                listBoxMsgIndex.Items.Add(i);
        }

        private int Output(System.Lazy<AE.Net.Mail.MailMessage>[] msgs)
        {
            foreach (var msg in msgs)
            {
                textBoxINBOX.Text += msg.Value.From.ToString() + "\n";
                textBoxINBOX.Text += msg.Value.Date.ToString() + "\n";
                textBoxINBOX.Text += msg.Value.Subject + "\n";
                textBoxINBOX.Text += msg.Value.Body + "\n";
                textBoxINBOX.Text = "\n\n=============================\n\n";
            }
            if (string.IsNullOrEmpty(textBoxINBOX.Text))
                textBoxINBOX.Text = "\tEmpty...";

            return msgs.Length;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            IC.DeleteMessage(IC.GetMessage(listBoxMsgIndex.SelectedIndex + 1));
            
            buttonReload_Click(sender, e);
        }
    }
}