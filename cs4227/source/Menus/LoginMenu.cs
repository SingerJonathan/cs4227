using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs4227.source.Menus
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
            UserMenu f7 = new UserMenu();
            f7.ShowDialog();
        }

        private void SysAdminLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysAdminMenu SAM = new SysAdminMenu();
            SAM.ShowDialog();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResMenu RM = new ResMenu();
            RM.ShowDialog();
        }

        public static void Main()
        {
            LoginMenu LG = new LoginMenu();
            LG.ShowDialog();
        }
    }
}
