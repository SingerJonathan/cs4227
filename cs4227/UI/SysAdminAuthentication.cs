using System;
using System.Windows.Forms;
using cs4227.Database;
using cs4227.User;

namespace cs4227.UI
{
    public partial class SysAdminAuthentication : Form
    {
        private readonly AbstractUser _user;
        private readonly ProxyAuthenticator _proxy;

        public SysAdminAuthentication(int userId)
        {
            _user = StaticAccessor.DB.GetUser(userId);

            _proxy = new ProxyAuthenticator();
            _proxy.SendAuthenticationCode(_user.Email);

            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (_proxy.VerifyAuthenticationCode(TwoStepCodeTextBox.Text))
            {
                Hide();
                _user.login();
            }
            else
                MessageBox.Show("Invalid authentication code.", "Authentication Failure");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginMenuV2();
        }

        private void TwoStepCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            TwoStepCodeTextBox.Text = TwoStepCodeTextBox.Text.ToUpper();
            TwoStepCodeTextBox.SelectionStart = TwoStepCodeTextBox.Text.Length;
            TwoStepCodeTextBox.SelectionLength = 0;
        }
    }
}
