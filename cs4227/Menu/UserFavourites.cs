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
    public partial class UserFavouriteOrders : Form
    {
        private int UserId = 0;

        public UserFavouriteOrders(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

  
        private void FavouriteOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //checkout
        {
            this.Hide();
            UserCheckout UC = new UserCheckout(UserId);
            UC.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //delete
        {
            //add code to delete from list
        }

        private void button3_Click(object sender, EventArgs e) //back
        {
            this.Hide();
            UserMainMenu UMM = new UserMainMenu(UserId);
            UMM.ShowDialog();
        }

    }
}
