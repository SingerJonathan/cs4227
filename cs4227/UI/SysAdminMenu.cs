using System;
using System.Windows.Forms;

namespace cs4227.UI
{
    public partial class SysAdminMenu : Form
    {
        private readonly Timer t = new Timer();
        private readonly int UserId;

        public SysAdminMenu(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void SysAdminMenu_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += UpdateTime_Tick;

            t.Start();
        }

        private void UpdateTime_Tick(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToString("dd/MM/yyyy");
            var time = DateTime.Now.ToString("h:mm:ss tt");
            DisplayDateLabel.Text = @"Date: " + date;
            DisplayTimeLabel.Text = @"Current Time: " + time;
        }

        private void RestaurantsButton_Click(object sender, EventArgs e)
        {
            Hide();
            var SRM = new SysAdminRestaurantsMenu(UserId);
            SRM.ShowDialog();
        }

        private void AdminsButton_Click(object sender, EventArgs e)
        {
            Hide();
            var SAAM = new SysAdminAdminsMenu(UserId);
            SAAM.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginMenuV2();
        }
    }
}