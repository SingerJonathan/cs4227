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
    public partial class SysViewOrder : Form
    {
        private int RestaurantId = 0;
        private int AdminId = 0;

        public SysViewOrder(int AdminId, int RestaurantId)
        {
            this.AdminId = AdminId;
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysViewRestaraunt SVR = new SysViewRestaraunt(AdminId, RestaurantId);
            SVR.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Order> orders = DatabaseHandler.GetOrders();
            foreach (Order order in orders)
            {
                if (order.RestaurantId == RestaurantId)
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
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + order.Cost));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + order.Address));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + (order.Cancelled ? "Yes" : "No")));
                    listView.Items.Add(row);
                }
            }
        }
    }
}
