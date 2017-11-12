using System;
using System.Windows.Forms;

namespace cs4227.UI
{
    public partial class UserMainMenu : Form
    {
        private readonly int UserId;

        public UserMainMenu(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var URS = new UserRestarauntSearch(UserId);
            URS.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var UOH = new UserOrderHistory(UserId);
            UOH.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            var UMA = new UserManageAccount(UserId, false);
            UMA.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginMenuV2();
        }
    }
}