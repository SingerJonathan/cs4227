using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs4227.UI
{
    public partial class UserMainMenu : Form
    {
        private int UserId = 0;

        public UserMainMenu(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserRestarauntSearch URS = new UserRestarauntSearch(UserId);
            URS.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrderHistory UOH = new UserOrderHistory(UserId);
            UOH.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManageAccount UMA = new UserManageAccount(UserId, false);
            UMA.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginMenuV2();
        }
    }
}
