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
    public partial class RestAdminMenuItem : Form
    {
        private int RestaurantId = 0;
        private string MenuItemName = "";
        private string Price = "0.0";
        private string ErrorMessage = "";
        private Boolean CorrectNameFormat = false;
        private Boolean CorrectPriceFormat = false;

        public RestAdminMenuItem(int RestaurantId)
        {
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            MenuItemName = NameTextbox.Text.ToString();

            if (MenuItemName.Length > 0)
            {
                if (MenuItemName.Any(char.IsSymbol) || MenuItemName.Any(char.IsPunctuation))
                {
                    ErrorMessage = "Can't use Symbols in a Menu Item Name";
                    CorrectNameFormat = false;
                }
                else
                {
                    CorrectNameFormat = true;
                }
            }
            else
            {
                CorrectNameFormat = false;
                ErrorMessage = "Can't have a blank Menu Item Name. Try Again!";
            }

            if (!CorrectNameFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                NameLabel.Text = "Name: ERROR";
            }
            else
            {
                ErrorMessageLabel.Visible = false;
                NameLabel.Text = "Name:";
            }
        }

        private void PriceTextbox_TextChanged(object sender, EventArgs e)
        {
            Price = PriceTextbox.Text.ToString();

            if (Price.Length > 0)
            {
                if (!Price.Any(char.IsDigit) || !Price.Any(char.IsWhiteSpace))
                {
                    ErrorMessage = "Enter Numbers Only \nFormat: 2 00 => €2.00";
                    CorrectPriceFormat = false;
                }
                else
                {
                    CorrectPriceFormat = true;
                }
            }
            else
            {
                CorrectPriceFormat = false;
            }

            if (!CorrectPriceFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                PriceLabel.Text = "Price: ERROR";
            }
            else
            {
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
                PriceLabel.Text = "Price:";
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (CorrectNameFormat && CorrectPriceFormat)
            {
                //check if item exists already
                ErrorMessageLabel.Visible = false;
                Boolean Exists = false;
                if (!Exists)
                {
                    //add to db
                    MessageBox.Show("Item:" + MenuItemName + " Added");
                }
                else
                {
                    ErrorMessage = "Item Already Exists";
                    CorrectNameFormat = false;
                }
            }
            else
            {
                ErrorMessageLabel.Visible = true;
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestAdminMenu RAM = new RestAdminMenu(RestaurantId);
            RAM.ShowDialog();
        }

        private void RestaurantMenuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get item id and get item name
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //remove item from db
            MessageBox.Show("Item: " + MenuItemName + " Removed");
        }
    }
}
