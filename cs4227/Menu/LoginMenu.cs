using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cs4227.User;

namespace cs4227.Menu
{
    public partial class LoginMenu : Form
    {
        Timer t = new Timer();
        private string RestaurantName = "";

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
            AbstractUser user = new UserFactory().getUser("michaeluserman96", "Michael Userman", "#Badpassword1", "User");
            user.login();
        }

        private void SysAdminLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbstractUser sysAdmin = new UserFactory().getUser("geoffsysman96", "Geoff Sysman", "#Badpassword1", "SysAdmin");
            sysAdmin.login();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbstractUser restAdmin = new UserFactory().getUser("larryrestman96", "Larry Restman", "#Badpassword1", "RestAdmin");
            restAdmin.login();
        }

        public static void Main()
        {
            LoginMenu LG = new LoginMenu();
            LG.ShowDialog();
        }
    }
}
