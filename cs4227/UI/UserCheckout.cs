using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cs4227.Restaurant;
using cs4227.Database;
using cs4227.Meal;

namespace cs4227.UI
{
    public partial class UserCheckout : Form
    {
        private int UserId = 0;
        private int OrderId = 0;
        private string Address = "";
        private string ErrorMessage = "";
        private int RestaurantId = 0;
        private Order Order;
        private List<Memento> Mementos;
        private Boolean CorrectAddressFormat = false;

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
            Address = AddressTextBox.Text.ToString();

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
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AddressLabel.Text = "Address: ERROR";
            }
            else
            {
                ErrorMessageLabel.Visible = false;
                AddressLabel.Text = "Address:";
            }
        }

        private void button2_Click(object sender, EventArgs e)  //change order
        {
            this.Hide();
            UserOrderMenu UOM = new UserOrderMenu(UserId, RestaurantId, Order, Mementos);
            UOM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) //place order
        {
            if (CorrectAddressFormat)
            {
                OrderId = StaticAccessor.DB.GetNewestOrderId() + 1;
                Order.Address = Address;

                PlaceOrderCommand placeOrderCommand = new PlaceOrderCommand(Order);
                StaticAccessor.Invoker.Command = placeOrderCommand;
                StaticAccessor.Invoker.Invoke();

                this.Hide();
                UserPlaceOrderMenu UPOM = new UserPlaceOrderMenu(UserId, OrderId);
                UPOM.ShowDialog();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMainMenu UMM = new UserMainMenu(UserId);
            UMM.ShowDialog();
        }

        private void UserCheckout_Load(object sender, EventArgs e)
        {
            int membership = StaticAccessor.DB.GetUser(UserId).Membership;
            if (membership == 0)
            {
                YourOrder.Columns.RemoveAt(2);
                YourOrder.Columns[0].Width += 200;
            }

            foreach (FoodItem Food in Order.FoodItems)
            {
                ListViewItem row = new ListViewItem(Food.Name);
                string cost = StaticAccessor.DoubleToMoneyString(Food.Cost);
                string discountedCost = StaticAccessor.DoubleToMoneyString(Food.Cost - Food.Discounts[membership]);
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, cost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, discountedCost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + Food.Id));
                YourOrder.Items.Add(row);
            }

            double deliveryCharge = StaticAccessor.DB.GetRestaurant(RestaurantId).Delivery;
            OrderPriceLabel.Text = "Price: " + StaticAccessor.DoubleToMoneyString(Order.Cost-deliveryCharge);
            DeliveryChargeLabel.Text = "Delivery: " + StaticAccessor.DoubleToMoneyString(deliveryCharge);
            PriceLabel.Text = "Total: " + StaticAccessor.DoubleToMoneyString(Order.Cost);
            ErrorMessageLabel.Visible = false;
        }
    }
}
