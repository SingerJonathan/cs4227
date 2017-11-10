using System;
using System.Collections.Generic;
using System.Windows.Forms;
using cs4227.Meal;
using cs4227.Restaurant;

namespace cs4227.UI
{
    public partial class UserOrderMenu : Form
    {
        private readonly List<Memento> Mementos;
        private readonly Order Order;
        private readonly int RestaurantId;
        private readonly int UserId;

        public UserOrderMenu(int UserId, int RestaurantId, Order Order, List<Memento> Mementos)
        {
            this.Mementos = Mementos;
            this.Order = Order;
            this.RestaurantId = RestaurantId;
            this.UserId = UserId;
            InitializeComponent();
        }

        private void UserOrderMenu_Load(object sender, EventArgs e)
        {
            Order.UserId = UserId;
            Order.RestaurantId = RestaurantId;

            var membership = StaticAccessor.DB.GetUser(UserId).Membership;
            if (membership == 0)
            {
                RestaurantMenu.Columns.RemoveAt(2);
                RestaurantMenu.Columns[0].Width += 170;
                YourOrder.Columns.RemoveAt(2);
                YourOrder.Columns[0].Width += 170;
            }

            var FoodItems = StaticAccessor.DB.GetFoodItems(RestaurantId);
            foreach (var Food in FoodItems)
            {
                var row = new ListViewItem(Food.Name);
                var cost = StaticAccessor.DoubleToMoneyString(Food.Cost);
                var discountedCost = StaticAccessor.DoubleToMoneyString(Food.Cost - Food.Discounts[membership]);
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, cost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, discountedCost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + Food.Id));
                RestaurantMenu.Items.Add(row);
            }

            foreach (var Food in Order.FoodItems)
            {
                var row = new ListViewItem(Food.Name);
                var cost = StaticAccessor.DoubleToMoneyString(Food.Cost);
                var discountedCost = StaticAccessor.DoubleToMoneyString(Food.Cost - Food.Discounts[membership]);
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, cost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, discountedCost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + Food.Id));
                YourOrder.Items.Add(row);
            }
            var delivery = StaticAccessor.DB.GetRestaurant(RestaurantId).Delivery;
            TotalCostLabel.Text = "" + StaticAccessor.DoubleToMoneyString(Order.Cost - delivery);
        }

        private void RestaurantMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YourOrder.Items.Count < 8 && RestaurantMenu.SelectedItems.Count > 0)
            {
                var selectedRow = RestaurantMenu.SelectedItems[0];
                YourOrder.Items.Add((ListViewItem) selectedRow.Clone());
                selectedRow.Selected = false;
                //order.Cost += Convert.ToDouble(selectedRow.SubItems[1].Text);
                Order.Add(StaticAccessor.DB.GetFoodItem(Convert.ToInt32(selectedRow.SubItems[3].Text)));
                Mementos.Add(Order.CreateMemento());
                TotalCostLabel.Text = "" + StaticAccessor.DoubleToMoneyString(Order.Cost);
                if (YourOrder.Items.Count >= 8)
                    MessageBox.Show(@"You've reached the item limit.");
            }
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (YourOrder.Items.Count > 0)
            {
                YourOrder.Items.RemoveAt(YourOrder.Items.Count - 1);
                try
                {
                    Order.SetMemento(Mementos[Mementos.Count - 2]);
                }
                catch
                {
                    Order.SetMemento(new Memento(Order.Id, Order.UserId, Order.Cancelled, new List<FoodItem>()));
                }
                Mementos.RemoveAt(Mementos.Count - 1);
                TotalCostLabel.Text = "" + StaticAccessor.DoubleToMoneyString(Order.Cost);
            }
        }

        /*private void YourOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YourOrder.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = YourOrder.SelectedItems[0];
                selectedRow.Remove();
            }
        }*/

        private void button1_Click(object sender, EventArgs e) //back
        {
            Hide();
            var URS = new UserRestarauntSearch(UserId);
            URS.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //checkout
        {
            Hide();
            var UC = new UserCheckout(UserId, RestaurantId, Order, Mementos);
            UC.ShowDialog();
        }
    }
}