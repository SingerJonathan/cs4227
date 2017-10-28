using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace cs4227.Menu
{
    public partial class UserManageAccount : Form
    {
        private int UserId = 0;
        private string Username = "";
        private string Password = "";
        private string Email = "";
        private string FullName = "";
        private string ErrorMessage = "";
        private Boolean CorrectEmailFormat = false;
        private Boolean CorrectNameFormat = false;
        private Boolean CorrectUsernameFormat = false;
        private Boolean CorrectPasswordFormat = false;
        private Boolean newAccount = false;

        public UserManageAccount(int UserId, Boolean newAccount)
        {
            this.newAccount = newAccount;
            this.UserId = UserId;
            InitializeComponent();
        }

        private void UserPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            Password = UserPasswordTextbox.Text.ToString();

            if (Password.Length > 4)
            {
                if (!Password.Any(char.IsUpper))
                {
                    CorrectPasswordFormat = false;
                    ErrorMessage = "Passwords must contain an Upper Case letter";
                }
                else if (!Password.Any(char.IsLower))
                {
                    CorrectPasswordFormat = false;
                    ErrorMessage = "Passwords must contain a Lower Case letter";
                }
                else if (!Password.Any(char.IsDigit))
                {
                    CorrectPasswordFormat = false;
                    ErrorMessage = "Passwords must contain a Number";
                }
                else if (!Password.Any(char.IsSymbol) && !Password.Any(char.IsPunctuation))
                {
                    CorrectPasswordFormat = false;
                    ErrorMessage = "Passwords must contain a Symbol";
                }
                else
                {
                    CorrectPasswordFormat = true;
                }
            }
            else
            {
                CorrectPasswordFormat = false;
                ErrorMessage = "Passwords Must be Longer than 4 characters. Try Again!";
            }

            if (!CorrectPasswordFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                UserPasswordLabel.Text = "Password: ERROR";
            }
            else
            {
                UserPasswordLabel.Text = "Password:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
            }
        }

        private void UserEmailTextbox_TextChanged(object sender, EventArgs e)
        {
            Email = UserEmailTextbox.Text.ToString();

            if (Email.Length > 0)
            {
                try
                {
                    MailAddress m = new MailAddress(Email);
                    CorrectEmailFormat = true;
                }
                catch (FormatException)
                {

                }
                if (!CorrectEmailFormat)
                {
                    ErrorMessage = "Incorrect Email Format. Try Again!";
                    CorrectEmailFormat = false;
                }
            }
            else
            {
                CorrectEmailFormat = false;
                ErrorMessage = "Can't have a blank Email. Try again!";
            }

            if (!CorrectEmailFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                UserEmailLabel.Text = "Email: ERROR";
            }
            else
            {
                Boolean EmailExists = false;
                //Add code to check if email already exists

                if (!EmailExists)
                {
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    UserEmailLabel.Text = "Email:";
                    CorrectEmailFormat = true;
                }
                else
                {
                    ErrorMessageLabel.Text = "Error Message: Email already exists. Try Again!";
                    ErrorMessageLabel.Visible = true;
                    UserEmailLabel.Text = "Email: ERROR";
                    CorrectEmailFormat = false;
                }
            }
        }

        private void UserNameTextbox_TextChanged(object sender, EventArgs e)
        {
            FullName = UserNameTextbox.Text.ToString();

            if (FullName.Length > 0)
            {
                CorrectNameFormat = true;
                if (FullName.Any(char.IsDigit))
                {
                    ErrorMessage = "Can't Use Numbers in a Name";
                    CorrectNameFormat = false;
                }

                if (FullName.Any(char.IsSymbol) || FullName.Any(char.IsPunctuation))
                {
                    ErrorMessage = "Can't Use Symbols in a Name";
                    CorrectNameFormat = false;
                }
            }
            else
            {
                CorrectNameFormat = false;
                ErrorMessage = "Can't have a blank Name. Try Again!";
            }

            if (!CorrectNameFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                UserNameLabel.Text = "Name: ERROR";
            }
            else
            {
                UserNameLabel.Text = "Name:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
            }
        }

        private void UserUsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            Username = UserUsernameTextbox.Text.ToString();

            if (Username.Length > 0)
            {
                if (Username.Any(char.IsPunctuation) || Username.Any(char.IsWhiteSpace))
                {
                    CorrectUsernameFormat = false;
                    ErrorMessage = "Can't Use Spaces or Punctuation for an Username";
                }
                else
                {
                    CorrectUsernameFormat = true;
                }
            }
            else
            {
                CorrectUsernameFormat = false;
                ErrorMessage = "Can't have a blank Username. Try Again!";
            }

            if (!CorrectUsernameFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                UserUsernameLabel.Text = "Username: ERROR";
            }
            else
            {
                Boolean UsernameExists = false;
                //Add code to check if username exists already

                if (!UsernameExists)
                {
                    UserUsernameLabel.Text = "Username:";
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                }
                else
                {
                    ErrorMessageLabel.Text = "Error Message: Username already exists. Try Again!";
                    ErrorMessageLabel.Visible = true;
                    UserUsernameLabel.Text = "Username: ERROR";
                    CorrectUsernameFormat = false;
                }
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (newAccount)
            {
                //insert
                MessageBox.Show("Account Created");
                this.Hide();
                LoginMenuV2 LMV2 = new LoginMenuV2();
                LMV2.ShowDialog();
            }
            else
            {
                //update or delete then insert
                MessageBox.Show("Changes Saved");
                this.Hide();
                UserMainMenu UMM = new UserMainMenu(UserId);
                UMM.ShowDialog();
            }
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            //delete account from db
            MessageBox.Show("Account Deleted \nReturning to login screen");
            this.Hide();
            LoginMenu LM = new LoginMenu();
            LM.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (newAccount)
            {
                this.Hide();
                LoginMenuV2 LMV2 = new LoginMenuV2();
                LMV2.ShowDialog();
            }
            else
            {
                this.Hide();
                UserMainMenu UMM = new UserMainMenu(UserId);
                UMM.ShowDialog();
            }
        }

        private void UserManageAccount_Load(object sender, EventArgs e)
        {
            if (!newAccount)
            {
                UserEmailTextbox.Text = Email;
                UserNameTextbox.Text = FullName;
                UserPasswordTextbox.Text = Password;
                UserUsernameTextbox.Text = Username;
            }
            else
            {
                DeleteAccountButton.Enabled = false;
                DeleteAccountButton.Hide();
                this.Text = "User Menu: Create Account";
                SaveChangesButton.Text = "Create Account";
                BackButton.Text = "Cancel";
            }
        }
    }
}
