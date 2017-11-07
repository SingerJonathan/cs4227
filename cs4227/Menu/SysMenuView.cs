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

namespace cs4227.Menu
{
    public partial class SysViewMenu : Form
    {
        private int RestaurantId = 0;
        private int AdminId = 0;

        public SysViewMenu(int AdminId, int RestaurantId)
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

        private void Form3_Load(object sender, EventArgs e)
        {
            List<FoodItem> items = DatabaseHandler.GetFoodItems();
            foreach (FoodItem item in items)
            {
                if (item.RestaurantId == RestaurantId)
                {
                    ListViewItem row = new ListViewItem("" + item.Id);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + DatabaseHandler.GetFoodItem(item.Id).Name));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + StaticAccessor.DoubleToMoneyString(item.Cost)));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + (item.Deleted ? "Yes" : "No")));
                    listView.Items.Add(row);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
