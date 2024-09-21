using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail
{
    public class SettingsData
    {
        public string Name { get; set; }
        public string Server { get; set; }
        public int Port { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MailBox { get; set; }
        public bool SSl { get; set; }

        public bool IsError = false;

        public void Clear()
        {
            Name = string.Empty;
            Server = string.Empty;
            Port = 0;
            Email = string.Empty;
            Password = string.Empty;
            MailBox = string.Empty;
            SSl = true;
            IsError = true;
        }

        public string IsNullOrEmpty(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                IsError = false;
                return text;
            }
            else
            {
                Error();
                return "";
            }
        }
        public void Error()
        {
            IsError = true;
            MessageBox.Show("Enter all fields properly", "Not all fields filled", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}