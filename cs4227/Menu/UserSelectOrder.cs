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

namespace cs4227.Menu
{
    public partial class UserOrderMenu : Form
    {
        private int UserId = 0;
        private int RestaurantId = 0;
        private List<Memento> Mementos;
        private Order Order;

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
            List<FoodItem> FoodItems = DatabaseHandler.GetRestaurantFoodItems(RestaurantId);
            foreach (FoodItem Food in FoodItems)
            {
                ListViewItem row = new ListViewItem(Food.Name);
                string cost = UserCheckout.DoubleToMoneyString(Food.Cost);
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, cost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + Food.Id));
                RestaurantMenu.Items.Add(row);
            }
            
            foreach (FoodItem Food in Order.FoodItems)
            {
                ListViewItem row = new ListViewItem(Food.Name);
                string cost = UserCheckout.DoubleToMoneyString(Food.Cost);
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, cost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + Food.Id));
                YourOrder.Items.Add(row);
            }
            TotalCostLabel.Text = "" + UserCheckout.DoubleToMoneyString(Order.Cost);
        }

        private void RestaurantMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YourOrder.Items.Count < 8 && RestaurantMenu.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = RestaurantMenu.SelectedItems[0];
                YourOrder.Items.Add((ListViewItem)selectedRow.Clone());
                selectedRow.Selected = false;
                //order.Cost += Convert.ToDouble(selectedRow.SubItems[1].Text);
                Order.Add(DatabaseHandler.GetFoodItem(Convert.ToInt32(selectedRow.SubItems[2].Text)));
                Mementos.Add(Order.CreateMemento());
                TotalCostLabel.Text = ""+UserCheckout.DoubleToMoneyString(Order.Cost);
                if (YourOrder.Items.Count >= 8)
                    MessageBox.Show("You've reached the item limit.");
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
                TotalCostLabel.Text = "" + UserCheckout.DoubleToMoneyString(Order.Cost);
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
            this.Hide();
            UserMainMenu UMM = new UserMainMenu(UserId);
            UMM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //checkout
        {
            this.Hide();
            UserCheckout UC = new UserCheckout(UserId, RestaurantId, Order, Mementos);
            UC.ShowDialog();
        }
    }
}
