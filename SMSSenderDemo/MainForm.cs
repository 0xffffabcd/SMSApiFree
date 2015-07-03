using System;
using System.Web;
using System.Windows.Forms;

namespace SMSSenderDemo
{
    public partial class MainForm : Form
    {
        // Username
        private string _username = "";
        // Password
        private string _password = "";
        // Maximum length
        private int _maxTextLength = 960;

        public MainForm()
        {
            InitializeComponent();
            notificationTextBox.MaxLength = _maxTextLength;
            statusLabel.Text = $"Characters: 0 / {_maxTextLength}";
        }

        private async void Button1Click(object sender, EventArgs e)
        {
            // Get your username and password after activating the option from here: 
            // https://mobile.free.fr/moncompte/index.php?page=options

            try
            {
                var lib = new FreeSMSLib.FreeSMSLib(_username, _password);
                MessageBox.Show(
                    await lib.SendNotification(HttpUtility.UrlEncode(notificationTextBox.Text))
                        ? "SMS sent"
                        : "Error while sending your SMS");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notificationTextBox_TextChanged(object sender, EventArgs e)
        {
            statusLabel.Text = $"Characters: {notificationTextBox.Text.Length} / {_maxTextLength}";
        }
    }
}
