using System;
using System.Windows.Forms;

namespace cs4227.UI
{
    public partial class RestAdminViewOrders : Form
    {
        private readonly int AdminId;
        private readonly int OrderNo;
        private readonly int RestaurantId;

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
            var order = StaticAccessor.DB.GetOrder(OrderNo, true);
            var row = new ListViewItem("" + order.Id);
            row.SubItems.Add(
                new ListViewItem.ListViewSubItem(row, "" + StaticAccessor.DB.GetUser(order.UserId).Username));
            for (var i = 0; i < 8; i++)
                if (i < order.FoodItems.Count)
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row,
                        StaticAccessor.DB.GetFoodItem(order.FoodItems[i].Id, true).Name));
                else
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, ""));
            var cost = order.Cost.ToString();
            if (cost.Length == 1 || cost.Length == 2)
                cost += ".00";
            row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + cost));
            row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + order.Address));
            row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + (order.Cancelled ? "Yes" : "No")));
            Order.Items.Add(row);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            var RAMO = new RestAdminManageOrders(AdminId, RestaurantId);
            RAMO.ShowDialog();
        }
    }
}