using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cs4227.Database;
using cs4227.Restaurant;
using cs4227.Meal;

namespace cs4227.UI
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
            List<Order> orders = DatabaseHandler.GetOrders(RestaurantId);
            foreach (Order order in orders)
            {
                if (order.RestaurantId == RestaurantId)
                {
                    ListViewItem row = new ListViewItem("" + order.Id);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + DatabaseHandler.GetUser(order.UserId).Username));
                    string cost = StaticAccessor.DoubleToMoneyString(order.Cost);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + cost));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + order.Address));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + (order.Cancelled ? "Yes" : "No")));
                    CurrentOrders.Items.Add(row);
                }
            }
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
            Order CancelOrder = DatabaseHandler.GetOrder(OrderNo);
            if (CancelOrder.Cancelled != true && OrderNo != 0)
            {
                CancelOrder.Cancelled = true;
                
                CancelOrderCommand cancelOrderCommand = new CancelOrderCommand(CancelOrder);
                StaticAccessor.Invoker.Command = cancelOrderCommand;
                StaticAccessor.Invoker.Invoke();

                //DatabaseHandler.UpdateOrder(CancelOrder);
                MessageBox.Show("Order No: " + CancelOrder.Id + " is now Cancelled");
                this.Hide();
                RestAdminManageOrders RAMO = new RestAdminManageOrders(AdminId, RestaurantId);
                RAMO.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select an Order to Cancel. \nSelect an Order that hasn't been Cancelled");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestAdminMainMenu RAM = new RestAdminMainMenu(AdminId, RestaurantId);
            RAM.ShowDialog();
        }
    }
}
