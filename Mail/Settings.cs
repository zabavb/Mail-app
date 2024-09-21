using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail
{
    public partial class Settings : Form
    {
        public SettingsData Data = new SettingsData();

        public Settings()
        {
            InitializeComponent();
            // Startup settings
            textBoxServer.Text = "[your server name].gmail.com";
            textBoxPort.Text = "[your port]";
            textBoxName.Text = "[your name]";
            textBoxEmail.Text = "[your email]";
            textBoxPassword.Text = "[your password]";
            textBoxMailBox.Text = "appTest";
            checkBoxSSl.Checked = true;
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Data.Name = Data.IsNullOrEmpty(textBoxName.Text);
            Data.Server = Data.IsNullOrEmpty(textBoxServer.Text);

            if (!string.IsNullOrEmpty(textBoxPort.Text))
            {
                char[] tmpChr = textBoxPort.Text.ToCharArray();
                for (int i = 0; i < tmpChr.Length; i++)
                {
                    if (char.IsNumber(tmpChr[i]))
                        Data.Port = int.Parse(textBoxPort.Text);
                    else
                        Data.Error();
                }
            }
            else
                Data.Error();

            Data.Email = Data.IsNullOrEmpty(textBoxEmail.Text + "@gmail.com");
            Data.Password = Data.IsNullOrEmpty(textBoxPassword.Text);
            Data.MailBox = Data.IsNullOrEmpty(textBoxMailBox.Text);
            Data.SSl = checkBoxSSl.Checked;

            if (Data.IsError)
                Data.Clear();
            else
            {
                MessageBox.Show("Settings saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }
    }
}