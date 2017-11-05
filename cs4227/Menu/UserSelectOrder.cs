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
        private List<Memento> mementos = new List<Memento>();
        private Order order = new Order();

        public UserOrderMenu(int UserId, int RestaurantId)
        {
            this.RestaurantId = RestaurantId;
            this.UserId = UserId;
            InitializeComponent();
        }

        private void UserOrderMenu_Load(object sender, EventArgs e)
        {
            order.UserId = UserId;
            List<FoodItem> FoodItems = DatabaseHandler.GetRestaurantFoodItems(RestaurantId);
            foreach (FoodItem Food in FoodItems)
            {
                ListViewItem row = new ListViewItem(Food.Name);
                string cost = Food.Cost.ToString();
                if (cost.Equals("0"))
                    cost = "0.00";
                else
                    cost = string.Format("{0:#.00}", Convert.ToDecimal(cost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, cost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + Food.Id));
                RestaurantMenu.Items.Add(row);
            }
        }

        private void RestaurantMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RestaurantMenu.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = RestaurantMenu.SelectedItems[0];
                YourOrder.Items.Add((ListViewItem)selectedRow.Clone());
                selectedRow.Selected = false;
                //order.Cost += Convert.ToDouble(selectedRow.SubItems[1].Text);
                order.Add(DatabaseHandler.GetFoodItem(Convert.ToInt32(selectedRow.SubItems[2].Text)));
                mementos.Add(order.CreateMemento());
                TotalCostLabel.Text = ""+order.Cost;
                if (TotalCostLabel.Text.Equals("0"))
                    TotalCostLabel.Text = "0.00";
                else
                    TotalCostLabel.Text = string.Format("{0:#.00}", Convert.ToDecimal(TotalCostLabel.Text));
            }
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (YourOrder.Items.Count > 0)
            {
                YourOrder.Items.RemoveAt(YourOrder.Items.Count - 1);
                try
                {
                    order.SetMemento(mementos[mementos.Count - 2]);
                }
                catch
                {
                    order.SetMemento(new Memento(order.Id, order.UserId, order.Cancelled, new List<FoodItem>()));
                }
                mementos.RemoveAt(mementos.Count - 1);
                TotalCostLabel.Text = "" + order.Cost;
                if (TotalCostLabel.Text.Equals("0"))
                    TotalCostLabel.Text = "0.00";
                else
                    TotalCostLabel.Text = string.Format("{0:#.00}", Convert.ToDecimal(TotalCostLabel.Text));
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
            UserCheckout UC = new UserCheckout(UserId, RestaurantId);
            UC.ShowDialog();
        }
    }
}
