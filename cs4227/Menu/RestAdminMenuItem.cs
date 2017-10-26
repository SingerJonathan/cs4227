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
    public partial class RestAdminMenuItem : Form
    {
        private int RestaurantId = 0;

        public RestAdminMenuItem(int RestaurantId)
        {
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestAdminMenu RAM = new RestAdminMenu(RestaurantId);
            RAM.ShowDialog();
        }

        private void RestaurantMenuList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
