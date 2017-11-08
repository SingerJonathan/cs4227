using System;
using System.Windows.Forms;
using cs4227.Database;
using cs4227.User;
using cs4227.Interceptor;
using cs4227.Interceptor.ConcreteInterceptor;

namespace cs4227.Menu
{
    public partial class LoginMenuV2 : Form
    {
        Timer t = new Timer();
        private Boolean UserFound = false;
        private string Username = "";
        private string Password = "";
        private int UserId = 0;

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
            //Check User is exists in db
            AbstractUser User = DatabaseHandler.UserLogin(Username, Password);
            if (User.Username == null)
            {
                UserFound = false;
            }
            else
            {
                UserFound = true;
            }
            if (UserFound)
            {
                LoginInterceptor interceptor = new ConcreteLoginInterceptor();
                Dispatcher dispatcher = new Dispatcher();
                dispatcher.RegisterInterceptor(interceptor);
                dispatcher.DispatchLoginInterceptor(interceptor,this);
                this.Hide();
                User.login();
            }
            else
            {
                MessageBox.Show("Login Failed");
                ErrorMessageLabel.Text = "Error Message: Incorrect Username or Password";
                ErrorMessageLabel.Visible = true;
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManageAccount UMA = new UserManageAccount(0, true);
            UMA.ShowDialog();
        }

        public string UsernameTextBox()
        {
            return UsernameTextbox.Text;
        }

    }
}
