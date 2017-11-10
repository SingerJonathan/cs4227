using System;
using System.Windows.Forms;
using cs4227.Meal;

namespace cs4227.UI
{
    public partial class RestAdminManageOrders : Form
    {
        private readonly int AdminId;
        private int OrderNo;
        private readonly int RestaurantId;

        public RestAdminManageOrders(int AdminId, int RestaurantId)
        {
            this.AdminId = AdminId;
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void RestAdminManageOrders_Load(object sender, EventArgs e)
        {
            var orders = StaticAccessor.DB.GetOrders(0, RestaurantId);
            foreach (var order in orders)
                if (order.RestaurantId == RestaurantId)
                {
                    var row = new ListViewItem("" + order.Id);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row,
                        "" + StaticAccessor.DB.GetUser(order.UserId).Username));
                    var cost = StaticAccessor.DoubleToMoneyString(order.Cost);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + cost));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + order.Address));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + (order.Cancelled ? "Yes" : "No")));
                    CurrentOrders.Items.Add(row);
                }
        }

        private void CurrentOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentOrders.SelectedItems.Count == 0)
                return;
            var row = CurrentOrders.SelectedItems[0];
            OrderNo = Convert.ToInt32(row.SubItems[0].Text);
        }

        private void ViewOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderNo != 0)
            {
                Hide();
                var RAVO = new RestAdminViewOrders(AdminId, RestaurantId, OrderNo);
                RAVO.ShowDialog();
            }
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            var CancelOrder = StaticAccessor.DB.GetOrder(OrderNo);
            if (CancelOrder.Cancelled != true && OrderNo != 0)
            {
                CancelOrder.Cancelled = true;

                var cancelOrderCommand = new CancelOrderCommand(CancelOrder);
                StaticAccessor.Invoker.Command = cancelOrderCommand;
                StaticAccessor.Invoker.Invoke();

                //DatabaseHandler.UpdateOrder(CancelOrder);
                MessageBox.Show("Order No: " + CancelOrder.Id + " is now Cancelled");
                Hide();
                var RAMO = new RestAdminManageOrders(AdminId, RestaurantId);
                RAMO.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select an Order to Cancel. \nSelect an Order that hasn't been Cancelled");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            var RAM = new RestAdminMainMenu(AdminId, RestaurantId);
            RAM.ShowDialog();
        }
    }
}