using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs4227.Menu
{
    public partial class UserPlaceOrderMenu : Form
    {
        private int UserId = 0;
        private int OrderId = 0;
        private double TotalCost = 0.0;
        private string currentTime = "";
        private string EDTime = "";

        public UserPlaceOrderMenu(int UserId, int OrderId)
        {
            this.UserId = UserId;
            this.OrderId = OrderId;
            InitializeComponent();
        }

        private void UserPlaceOrderMenu_Load(object sender, EventArgs e)
        {
            //getOrderid and Cost
            OrderIdLabel.Text = "Order ID: " + OrderId.ToString();
            TotalCostLabel.Text = "Total Cost: " + TotalCost.ToString();
            currentTime = DateTime.Now.ToString("h:mm");
            OrderPlacedLabel.Text = "Time: " + currentTime;
            Random num = new Random();
            int mins = num.Next(40, 100);
            int hours = 0;
            if (mins > 60)
            {
                hours = mins / 60;
                mins = mins - 60;
            }
            EDTime = hours + " Hours, " + mins + " Minutes";
            EDTLabel.Text = "Estimated Delivery Time: " + EDTime; 
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMainMenu UMM = new UserMainMenu(UserId);
            UMM.ShowDialog();
        }
    }
}
