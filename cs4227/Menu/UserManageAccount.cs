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
using cs4227.Database;
using cs4227.User;

namespace cs4227.Menu
{
    public partial class UserManageAccount : Form
    {
        private int UserId = 0;
        private string Username = "";
        private string Password = "";
        private string Email = "";
        private string FirstName = "";
        private string LastName = "";
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

        private void UserManageAccount_Load(object sender, EventArgs e)
        {
            if (!newAccount)
            {
                AbstractUser User = DatabaseHandler.GetUser(UserId);
                Email = User.Email;
                FirstName = User.FirstName;
                LastName = User.LastName;
                Password = User.Password;
                Username = User.Username;
                UserEmailTextbox.Text = Email;
                UserFirstNameTextbox.Text = FirstName;
                UserLastNameTextbox.Text = LastName;
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

        private void UserFirstNameTextbox_TextChanged(object sender, EventArgs e)
        {
            FirstName = UserFirstNameTextbox.Text.ToString();

            if (FirstName.Length > 0)
            {
                CorrectNameFormat = true;
                if (FirstName.Any(char.IsDigit))
                {
                    ErrorMessage = "Can't Use Numbers in a Name";
                    CorrectNameFormat = false;
                }

                if (FirstName.Any(char.IsSymbol) || FirstName.Any(char.IsPunctuation))
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
                UserFirstNameLabel.Text = "First Name: ERROR";
            }
            else
            {
                UserFirstNameLabel.Text = "First Name:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
            }
        }

        private void UserLastNameTextbox_TextChanged(object sender, EventArgs e)
        {
            LastName = UserLastNameTextbox.Text.ToString();

            if (LastName.Length > 0)
            {
                CorrectNameFormat = true;
                if (LastName.Any(char.IsDigit))
                {
                    ErrorMessage = "Can't Use Numbers in a Name";
                    CorrectNameFormat = false;
                }

                if (LastName.Any(char.IsSymbol) || LastName.Any(char.IsPunctuation))
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
                UserLastNameLabel.Text = "Last Name: ERROR";
            }
            else
            {
                UserLastNameLabel.Text = "Last Name:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
            }
        }

        private void UserUsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            if(!newAccount)
            {
                UserUsernameTextbox.Text = Username;
            }
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
                if (newAccount)
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
                else
                {
                    UserUsernameTextbox.Text = Username;
                }
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (newAccount)
            {
                //DatabaseHandler.InsertUser();
                MessageBox.Show("Account Created");
                this.Hide();
                LoginMenuV2 LMV2 = new LoginMenuV2();
                LMV2.ShowDialog();
            }
            else
            {
                AbstractUser user = DatabaseHandler.GetUser(UserId);
                user.FirstName = FirstName;
                user.LastName = LastName;
                user.Username = Username;
                user.Password = Password;
                user.Email = Email;
                DatabaseHandler.UpdateUser(user);
                MessageBox.Show("Changes Saved");
                this.Hide();
                UserMainMenu UMM = new UserMainMenu(UserId);
                UMM.ShowDialog();
            }
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Username + ", are you sure you want to delete your account?", "Delete Account", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AbstractUser user = DatabaseHandler.GetUser(UserId);
                user.Deleted = true;
                DatabaseHandler.UpdateUser(user);
                
                MessageBox.Show("Account Deleted \nReturning to login screen");
                this.Hide();
                LoginMenuV2 LM = new LoginMenuV2();
                LM.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
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
    }
}
