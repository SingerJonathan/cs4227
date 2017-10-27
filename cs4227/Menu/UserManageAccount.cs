using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs4227.Menu
{
    public partial class UserManageAccount : Form
    {
        private int UserId = 0;
        private string Username = "";
        private string Password = "";
        private string Email = "";
        private string RestName = "";

        public UserManageAccount(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void UserPasswordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserEmailTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserUsernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMainMenu UMM = new UserMainMenu(UserId);
            UMM.ShowDialog();
        }

        private void UserManageAccount_Load(object sender, EventArgs e)
        {
            UserEmailTextbox.Text = Email;
            UserNameTextbox.Text = RestName;
            UserPasswordTextbox.Text = Password;
            UserUsernameTextbox.Text = Username;
        }
    }
}
