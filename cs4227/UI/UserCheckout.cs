using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using cs4227.Meal;
using cs4227.Restaurant;

namespace cs4227.UI
{
    public partial class UserCheckout : Form
    {
        private string Address = "";
        private bool CorrectAddressFormat;
        private string ErrorMessage = "";
        private readonly List<Memento> Mementos;
        private readonly Order Order;
        private int OrderId;
        private readonly int RestaurantId;
        private readonly int UserId;

        public UserCheckout(int UserId, int RestaurantId, Order Order, List<Memento> Mementos)
        {
            this.Mementos = Mementos;
            this.Order = Order;
            this.UserId = UserId;
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            Address = AddressTextBox.Text;

            if (Address.Length > 0)
            {
                if (Address.Any(char.IsSymbol) || Address.Any(char.IsPunctuation))
                {
                    ErrorMessage = "Can't use Symbols \nin a Restaurant's Address";
                    CorrectAddressFormat = false;
                }
                else
                {
                    CorrectAddressFormat = true;
                }
            }
            else
            {
                CorrectAddressFormat = false;
                ErrorMessage = "Can't have a blank Restaurant Address. \nTry Again!";
            }

            if (!CorrectAddressFormat)
            {
                ErrorMessageLabel.Text = @"Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AddressLabel.Text = @"Address: ERROR";
            }
            else
            {
                ErrorMessageLabel.Visible = false;
                AddressLabel.Text = @"Address:";
            }
        }

        private void button2_Click(object sender, EventArgs e) //change order
        {
            Hide();
            var UOM = new UserOrderMenu(UserId, RestaurantId, Order, Mementos);
            UOM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) //place order
        {
            if (CorrectAddressFormat)
            {
                OrderId = StaticAccessor.DB.GetNewestOrderId() + 1;
                Order.Address = Address;

                var placeOrderCommand = new PlaceOrderCommand(Order);
                StaticAccessor.Invoker.Command = placeOrderCommand;
                StaticAccessor.Invoker.Invoke();

                Hide();
                var UPOM = new UserPlaceOrderMenu(UserId, OrderId);
                UPOM.ShowDialog();
            }
        }

        private void UserCheckout_Load(object sender, EventArgs e)
        {
            var membership = StaticAccessor.DB.GetUser(UserId).Membership;
            if (membership == 0)
            {
                YourOrder.Columns.RemoveAt(2);
                YourOrder.Columns[0].Width += 200;
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

            var deliveryCharge = StaticAccessor.DB.GetRestaurant(RestaurantId).Delivery;
            OrderPriceLabel.Text = @"Price: " + StaticAccessor.DoubleToMoneyString(Order.Cost - deliveryCharge);
            DeliveryChargeLabel.Text = @"Delivery: " + StaticAccessor.DoubleToMoneyString(deliveryCharge);
            PriceLabel.Text = @"Total: " + StaticAccessor.DoubleToMoneyString(Order.Cost);
            ErrorMessageLabel.Visible = false;
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            Hide();
            var URS = new UserRestarauntSearch(UserId);
            URS.ShowDialog();
        }
    }
}