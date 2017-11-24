using System;
using System.Collections.Generic;
using System.Windows.Forms;
using cs4227.Meal;
using cs4227.Restaurant;

namespace cs4227.UI
{
    public partial class UserOrderHistory : Form
    {
        private readonly int UserId;

        public UserOrderHistory(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void UserOrderHistory_Load(object sender, EventArgs e)
        {
            var orders = StaticAccessor.DB.GetOrders(UserId);
            foreach (var order in orders)
            {
                var row = new ListViewItem("" + order.Id);
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row,
                    "" + StaticAccessor.DB.GetRestaurant(order.RestaurantId).Name));
                for (var i = 0; i < 8; i++)
                    if (i < order.FoodItems.Count)
                        row.SubItems.Add(new ListViewItem.ListViewSubItem(row,
                            StaticAccessor.DB.GetFoodItem(order.FoodItems[i].Id, true).Name));
                    else
                        row.SubItems.Add(new ListViewItem.ListViewSubItem(row, ""));
                var cost = StaticAccessor.DoubleToMoneyString(order.Cost);
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + cost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + order.Address));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + (order.Cancelled ? "Yes" : "No")));
                UserOrders.Items.Add(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            var UMM = new UserMainMenu(UserId);
            UMM.ShowDialog();
        }


        private void Orders_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}