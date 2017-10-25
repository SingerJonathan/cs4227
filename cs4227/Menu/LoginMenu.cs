using System;
using System.Windows.Forms;
using cs4227.User;

namespace cs4227.Menu
{
    public partial class LoginMenu : Form
    {
        Timer t = new Timer();

        public LoginMenu()
        {
            InitializeComponent();
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.UpdateTime_Tick);

            t.Start();
        }

        private void UpdateTime_Tick(object sender, EventArgs e)
        {
            String date = DateTime.Now.ToString("dd/MM/yyyy");
            String time = DateTime.Now.ToString("h:mm:ss tt");
            DisplayDateLabel.Text = "Date: " + date;
            DisplayTimeLabel.Text = "Current Time: " + time;
        }

        private void UserLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // HARD CODED VALUES, REPLACE WHEN LOGIN IS IMPLEMENTED
            AbstractUser user = new UserFactory().getUser(9, "michaeluserman96", "Michael", "Userman", "#Badpassword1", "michaeluserman96@gmail.com", "User");
            user.login();
        }

        private void SysAdminLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // HARD CODED VALUES, REPLACE WHEN LOGIN IS IMPLEMENTED
            AbstractUser sysAdmin = new UserFactory().getUser(1, "geoffsysman96", "Geoff", "Sysman", "#Badpassword1", "geoffsysman96@gmail.com", "SysAdmin", 0, true);
            sysAdmin.login();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // HARD CODED VALUES, REPLACE WHEN LOGIN IS IMPLEMENTED
            AbstractUser restAdmin = new UserFactory().getUser(8, "larryrestman96", "Larry", "Restman", "#Badpassword1", "larryrestman96@gmail.com", "RestAdmin", 1);
            restAdmin.login();
        }

        public static void Main()
        {
            LoginMenu LG = new LoginMenu();
            LG.ShowDialog();
        }
    }
}
