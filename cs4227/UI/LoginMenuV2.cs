using System;
using System.Windows.Forms;
using cs4227.Database;
using cs4227.User;

namespace cs4227.UI
{
    public partial class LoginMenuV2 : Form
    {
        Timer t = new Timer();
        private Boolean UserFound = false;
        private string Username = "";
        private string Password = "";
        private int ShowPassword = 1;

        public LoginMenuV2()
        {
            InitializeComponent();
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.UpdateTime_Tick);

            t.Start();

            ErrorMessageLabel.Visible = false;
        }

        private void UpdateTime_Tick(object sender, EventArgs e)
        {
            String date = DateTime.Now.ToString("dd/MM/yyyy");
            String time = DateTime.Now.ToString("h:mm:ss tt");
            DisplayDateLabel.Text = "Date: " + date;
            DisplayTimeLabel.Text = "Current Time: " + time;
        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            Username = UsernameTextbox.Text.ToString();
        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            Password = PasswordTextbox.Text.ToString();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Hash password input so the raw password isn't stored in the database
            string hashPassword = StaticAccessor.HashString(Password);

            AbstractUser User = DatabaseHandler.GetUser(Username);

            //Check User exists in db and compare hashed passwords
            if (User.Username == null || !User.Password.Equals(hashPassword))
            {
                UserFound = false;
            }
            else
            {
                UserFound = true;
            }
            if (UserFound)
            {
                this.Hide();
                User.login();
            }
            else
            {
                MessageBox.Show("Login Falied");
                ErrorMessageLabel.Text = "Error Message: Incorrect Username or Password";
                ErrorMessageLabel.Visible = true;
                PasswordTextbox.Text = "";
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManageAccount UMA = new UserManageAccount(0, true);
            UMA.ShowDialog();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowPassword = ShowPassword * -1;
            if (ShowPassword == -1)
                PasswordTextbox.PasswordChar = '\0';
            else
                PasswordTextbox.PasswordChar = '*';
        }
    }
}
