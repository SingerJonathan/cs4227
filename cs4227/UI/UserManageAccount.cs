using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using cs4227.User;

namespace cs4227.UI
{
    public partial class UserManageAccount : Form
    {
        private bool CorrectEmailFormat;
        private bool CorrectNameFormat;
        private bool CorrectPasswordFormat;
        private bool CorrectUsernameFormat;
        private string Email = "";
        private string ErrorMessage = "";
        private string FirstName = "";
        private string LastName = "";
        private int Membership;
        private readonly bool newAccount;
        private string Password = "";
        private int ShowPassword = 1;
        private readonly int UserId;
        private string Username = "";

        public UserManageAccount(int UserId, bool newAccount)
        {
            this.newAccount = newAccount;
            this.UserId = UserId;
            InitializeComponent();
        }

        private void UserManageAccount_Load(object sender, EventArgs e)
        {
            if (!newAccount)
            {
                var User = StaticAccessor.DB.GetUser(UserId);
                Email = User.Email;
                FirstName = User.FirstName;
                LastName = User.LastName;
                Password = User.Password;
                Username = User.Username;
                Membership = User.Membership;
                UserEmailTextbox.Text = Email;
                UserFirstNameTextbox.Text = FirstName;
                UserLastNameTextbox.Text = LastName;
                UserUsernameTextbox.Text = Username;
            }
            else
            {
                DeleteAccountButton.Enabled = false;
                ErrorMessageLabel.Visible = false;
                DeleteAccountButton.Hide();
                Text = @"User Menu: Create Account";
                SaveChangesButton.Text = @"Create Account";
                BackButton.Text = @"Cancel";
            }
            MembershipComboBox.SelectedIndex = Membership;
        }

        private void UserPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            Password = UserPasswordTextbox.Text;

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
                ErrorMessageLabel.Text = @"Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                UserPasswordLabel.Text = @"Password: ERROR";
            }
            else
            {
                UserPasswordLabel.Text = @"Password:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
            }
        }

        private void UserEmailTextbox_TextChanged(object sender, EventArgs e)
        {
            Email = UserEmailTextbox.Text;

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
                ErrorMessageLabel.Text = @"Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                UserEmailLabel.Text = @"Email: ERROR";
            }
            else
            {
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    UserEmailLabel.Text = "Email:";
                    CorrectEmailFormat = true;
            }
        }

        private void UserFirstNameTextbox_TextChanged(object sender, EventArgs e)
        {
            FirstName = UserFirstNameTextbox.Text;

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
                ErrorMessageLabel.Text = @"Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                UserFirstNameLabel.Text = @"First Name: ERROR";
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
            LastName = UserLastNameTextbox.Text;

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
                ErrorMessageLabel.Text = @"Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                UserLastNameLabel.Text = @"Last Name: ERROR";
            }
            else
            {
                UserLastNameLabel.Text = @"Last Name:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
            }
        }

        private void UserUsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!newAccount)
                UserUsernameTextbox.Text = Username;
            Username = UserUsernameTextbox.Text;


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
                ErrorMessageLabel.Text = @"Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                UserUsernameLabel.Text = @"Username: ERROR";
            }
            else
            {
                if (newAccount)
                {

                        UserUsernameLabel.Text = @"Username:";
                        ErrorMessage = "";
                        ErrorMessageLabel.Visible = false;
                }
                else
                {
                    UserUsernameTextbox.Text = Username;
                }
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (CorrectEmailFormat && CorrectNameFormat && CorrectUsernameFormat &&
                CorrectPasswordFormat /* && CorrectRestaurantFormat*/)
            {
                //Hash password input so the raw password isn't stored in the database
                var hashPassword = StaticAccessor.HashString(Password);

                if (newAccount)
                {
                    var user = new UserFactory().GetUser(0, Username, hashPassword, FirstName, LastName, Email,
                        Membership,
                        "User");
                    StaticAccessor.DB.InsertUser(user);
                    MessageBox.Show(@"Account Created");
                    Hide();
                    new LoginMenuV2();
                }
                else
                {
                    var user = StaticAccessor.DB.GetUser(UserId);
                    user.FirstName = FirstName;
                    user.LastName = LastName;
                    user.Username = Username;
                    user.Password = hashPassword;
                    user.Email = Email;
                    user.Membership = Membership;
                    StaticAccessor.DB.UpdateUser(user);
                    MessageBox.Show(@"Changes Saved");
                    Hide();
                    var UMM = new UserMainMenu(UserId);
                    UMM.ShowDialog();
                }
            }
            else
            {
                ErrorMessageLabel.Text = "Error Message: Please Fix Any Issues with your details";
                ErrorMessageLabel.Visible = true;
            }
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(Username + @", are you sure you want to delete your account?",
                @"Delete Account", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var user = StaticAccessor.DB.GetUser(UserId);
                user.Deleted = true;
                StaticAccessor.DB.UpdateUser(user);

                MessageBox.Show(@"Account Deleted Returning to login screen");
                Hide();
                new LoginMenuV2();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (newAccount)
            {
                Hide();
                new LoginMenuV2();
            }
            else
            {
                Hide();
                var UMM = new UserMainMenu(UserId);
                UMM.ShowDialog();
            }
        }

        private void MembershipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Membership = MembershipComboBox.SelectedIndex;
        }

        private void PasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ShowPassword = ShowPassword * -1;
            if (ShowPassword == -1)
                UserPasswordTextbox.PasswordChar = '\0';
            else
                UserPasswordTextbox.PasswordChar = '*';
        }
    }
}