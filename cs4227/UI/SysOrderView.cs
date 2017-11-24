using System;
using System.Windows.Forms;

namespace cs4227.UI
{
    public partial class SysViewOrder : Form
    {
        private readonly int AdminId;
        private readonly int RestaurantId;

        public SysViewOrder(int AdminId, int RestaurantId)
        {
            this.AdminId = AdminId;
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var SVR = new SysViewRestaraunt(AdminId, RestaurantId);
            SVR.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var orders = StaticAccessor.DB.GetOrders();
            foreach (var order in orders)
                if (order.RestaurantId == RestaurantId)
                {
                    var row = new ListViewItem("" + order.Id);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row,
                        "" + StaticAccessor.DB.GetUser(order.UserId).Username));
                    for (var i = 0; i < 8; i++)
                        if (i < order.FoodItems.Count)
                            row.SubItems.Add(new ListViewItem.ListViewSubItem(row,
                                StaticAccessor.DB.GetFoodItem(order.FoodItems[i].Id, true).Name));
                        else
                            row.SubItems.Add(new ListViewItem.ListViewSubItem(row, ""));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row,
                        "" + StaticAccessor.DoubleToMoneyString(order.Cost)));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + order.Address));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + (order.Cancelled ? "Yes" : "No")));
                    listView.Items.Add(row);
                }
        }
    }
}