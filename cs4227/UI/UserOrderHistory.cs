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
    public partial class UserOrderHistory : Form
    {
        private int UserId = 0;
        private int RestaurantId = 0;

        public UserOrderHistory(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void UserOrderHistory_Load(object sender, EventArgs e)
        {
            List<Order> orders = StaticAccessor.DB.GetOrders(UserId);
            foreach (Order order in orders)
            {
                ListViewItem row = new ListViewItem("" + order.Id);
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + StaticAccessor.DB.GetRestaurant(order.RestaurantId).Name));
                for (int i = 0; i < 8; i++)
                {
                    if (i < order.FoodItems.Count)
                        row.SubItems.Add(new ListViewItem.ListViewSubItem(row, StaticAccessor.DB.GetFoodItem(order.FoodItems[i].Id).Name));
                    else
                        row.SubItems.Add(new ListViewItem.ListViewSubItem(row, ""));
                }
                string cost = StaticAccessor.DoubleToMoneyString(order.Cost - StaticAccessor.DB.GetRestaurant(order.RestaurantId).Delivery);
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + cost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + order.Address));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + (order.Cancelled ? "Yes" : "No")));
                UserOrders.Items.Add(row);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMainMenu UMM = new UserMainMenu(UserId);
            UMM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrderMenu UOM = new UserOrderMenu(UserId, RestaurantId, new Order(), new List<Meal.Memento>());
            UOM.ShowDialog();
        }

        private void Orders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
