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
    public partial class RestAdminManageOrders : Form
    {
        private int RestaurantId = 0;
        private int AdminId = 0;
        private int OrderNo = 0;

        public RestAdminManageOrders(int AdminId, int RestaurantId)
        {
            this.AdminId = AdminId;
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void RestAdminManageOrders_Load(object sender, EventArgs e)
        {
            //display orders from database
        }

        private void CurrentOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentOrders.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem row = CurrentOrders.SelectedItems[0];
            OrderNo = Convert.ToInt32(row.SubItems[0].Text);
        }

        private void ViewOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderNo != 0)
            {
                this.Hide();
                RestAdminViewOrders RAVO = new RestAdminViewOrders(AdminId, RestaurantId, OrderNo);
                RAVO.ShowDialog();
            }
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            //add code to cancel order
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestAdminMainMenu RAM = new RestAdminMainMenu(AdminId, RestaurantId);
            RAM.ShowDialog();
        }
    }
}
