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
    public partial class UserCheckout : Form
    {
        private int UserId = 0;
        private int OrderId = 0;
        private string Address = "";
        private string ErrorMessage = "";
        private int RestaurantId = 0;
        private Boolean CorrectAddressFormat = false;

        public UserCheckout(int UserId, int RestaurantId)
        {
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
            UserOrderMenu UOM = new UserOrderMenu(UserId, RestaurantId);
            UOM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) //place order
        {
            if (CorrectAddressFormat)
            {
                //add order to db
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
            //Add code to display order and display cost
            ErrorMessageLabel.Visible = false;
        }
    }
}
