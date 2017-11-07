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

namespace cs4227.UI
{
    public partial class RestAdminViewOrders : Form
    {
        private int AdminId = 0;
        private int RestaurantId = 0;
        private int OrderNo = 0;
        private string Username = "";
        private string Item00 = "";
        private string Item01 = "";
        private string Item02 = "";
        private string Item03 = "";
        private string Item04 = "";
        private string Item05 = "";
        private string Item06 = "";
        private string Item07 = "";
        private string Item08 = "";
        private string Item09 = "";
        private double Cost = 0.0;
        private string DeliveryAddress = "";
        private Boolean IsCancelled = false;
        


        public RestAdminViewOrders(int AdminId, int RestaurantId, int OrderNo)
        {
            this.AdminId = AdminId;
            this.RestaurantId = RestaurantId;
            this.OrderNo = OrderNo;
            InitializeComponent();
        }

        private void RestAdminViewOrders_Load(object sender, EventArgs e)
        {
            OrderNumberLabel.Text = "Viewing Order No: " + OrderNo;

            List<Order> orders = DatabaseHandler.GetRestaurantOrder(OrderNo, RestaurantId);
            foreach (Order order in orders)
            {
                ListViewItem row = new ListViewItem("" + order.Id);
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + DatabaseHandler.GetUser(order.UserId).Username));
                for (int i = 0; i < 8; i++)
                {
                    if (i < order.FoodItems.Count)
                        row.SubItems.Add(new ListViewItem.ListViewSubItem(row, DatabaseHandler.GetFoodItem(order.FoodItems[i].Id).Name));
                    else
                        row.SubItems.Add(new ListViewItem.ListViewSubItem(row, ""));
                }
                string cost = order.Cost.ToString();
                if (cost.Length == 1 || cost.Length == 2)
                {
                    cost += ".00";
                }
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + cost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + order.Address));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + (order.Cancelled ? "Yes" : "No")));
                Order.Items.Add(row);

            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestAdminManageOrders RAMO = new RestAdminManageOrders(AdminId, RestaurantId);
            RAMO.ShowDialog();
        }
    }
}
