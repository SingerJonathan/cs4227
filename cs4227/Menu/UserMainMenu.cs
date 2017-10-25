using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs4227.Menu
{
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserResterauntSearch f8 = new UserResterauntSearch();
            f8.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrderHistory f9 = new UserOrderHistory();
            f9.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserFavouriteOrders f10 = new UserFavouriteOrders();
            f10.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManageAccount f11 = new UserManageAccount();
            f11.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMenu LG = new LoginMenu();
            LG.ShowDialog();
        }
    }
}
