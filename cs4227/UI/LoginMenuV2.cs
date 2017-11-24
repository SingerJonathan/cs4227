using System;
using System.Windows.Forms;
using cs4227.Client;
using cs4227.Meal;

namespace cs4227.UI
{
    public partial class LoginMenuV2 : Form
    {
        private string Password = "";
        private int ShowPassword = 1;
        private readonly Timer t = new Timer();
        private bool UserFound;
        private string Username = "";

        public LoginMenuV2()
        {
            InitializeComponent();
            ShowDialog();
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += UpdateTime_Tick;

            t.Start();

            WelcomeMessageLabel.Text = $"Welcome to {StaticAccessor.AppName}!";

            ErrorMessageLabel.Visible = false;
        }

        private void UpdateTime_Tick(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToString("dd/MM/yyyy");
            var time = DateTime.Now.ToString("h:mm:ss tt");
            DisplayDateLabel.Text = "Date: " + date;
            DisplayTimeLabel.Text = "Current Time: " + time;
        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            Username = UsernameTextbox.Text;
        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            Password = PasswordTextbox.Text;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Hash password input so the raw password isn't stored in the database
            var hashPassword = StaticAccessor.HashString(Password);

            var User = StaticAccessor.DB.GetUser(0, Username);

            //Check User exists in db and compare hashed passwords
            if (User.Username == null || !User.Password.Equals(hashPassword))
                UserFound = false;
            else
                UserFound = true;
            if (UserFound)
            {
                Interceptor interceptor = new ConcreteLoginInterceptor();
                var dispatcher = new Dispatcher();
                dispatcher.RegisterInterceptor(interceptor);
                if (User.SystemAdmin)
                {
                    Hide();
                    var SAA = new SysAdminAuthentication(User.Id);
                    SAA.ShowDialog();
                }
                else
                {
                    if (User.RestaurantAdmin && User.RestaurantId == 0)
                    {
                        MessageBox.Show("Login Failed");
                        ErrorMessageLabel.Text = "Error Message: Admin not assigned to a restaurant";
                        ErrorMessageLabel.Visible = true;
                        PasswordTextbox.Text = "";
                    }
                    else
                    {
                        dispatcher.DispatchLoginInterceptor(interceptor, this);
                        Hide();
                        User.login();
                    }
                }
            }
            else
            {
                MessageBox.Show("Login Failed");
                ErrorMessageLabel.Text = "Error Message: Incorrect Username or Password";
                ErrorMessageLabel.Visible = true;
                PasswordTextbox.Text = "";
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Hide();
            var UMA = new UserManageAccount(0, true);
            UMA.ShowDialog();
        }


        public string UsernameTextBox()
        {
            return UsernameTextbox.Text;
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