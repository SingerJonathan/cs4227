using System;
using System.Windows.Forms;

namespace cs4227.UI
{
    public partial class UserPlaceOrderMenu : Form
    {
        private string currentTime = "";
        private string EDTime = "";
        private readonly int OrderId;
        private double TotalCost;
        private readonly int UserId;

        public UserPlaceOrderMenu(int UserId, int OrderId)
        {
            this.UserId = UserId;
            this.OrderId = OrderId;
            InitializeComponent();
        }

        private void UserPlaceOrderMenu_Load(object sender, EventArgs e)
        {
            var order = StaticAccessor.DB.GetOrder(OrderId);
            var restaurant = StaticAccessor.DB.GetRestaurant(order.RestaurantId);
            TotalCost = order.Cost + restaurant.Delivery;

            //getOrderid and Cost
            OrderIdLabel.Text = @"Order ID: " + OrderId;
            TotalCostLabel.Text = @"Total Cost: " + StaticAccessor.DoubleToMoneyString(TotalCost);
            currentTime = DateTime.Now.ToString("h:mm");
            TimeLabel.Text = @"Time: " + currentTime;
            var num = new Random();
            var mins = num.Next(40, 100);
            var hours = 0;
            if (mins > 60)
            {
                hours = mins / 60;
                mins = mins - 60;
            }
            EDTime = hours + " Hours, " + mins + " Minutes";
            EDTLabel.Text = @"Estimated Delivery Time: " + EDTime;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            var UMM = new UserMainMenu(UserId);
            UMM.ShowDialog();
        }
    }
}