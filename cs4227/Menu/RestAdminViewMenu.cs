using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using cs4227.Database;
using cs4227.Restaurant;
using System.Text.RegularExpressions;

namespace cs4227.Menu
{
    public partial class RestAdminViewMenu : Form
    {
        private int RestaurantId = 0;
        private int AdminId = 0;
        private int MenuItemId = 0;
        private string MenuItemName = "";
        private string Price = "0.00";
        private string ErrorMessage = "";
        private Boolean CorrectNameFormat = false;
        private Boolean CorrectPriceFormat = false;
        private Boolean Delete = false;

        public RestAdminViewMenu(int AdminId, int RestaurantId)
        {
            this.AdminId = AdminId;
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void RestAdminViewMenu_Load(object sender, EventArgs e)
        {
            PriceTextbox.Text = Price;
            List<FoodItem> FoodItems = DatabaseHandler.GetRestaurantFoodItems(RestaurantId);
            foreach (FoodItem Food in FoodItems)
            {
                ListViewItem row = new ListViewItem("" + Food.Id);
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + Food.Name));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + Food.Cost));
                RestaurantMenuList.Items.Add(row);
            }
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
                ErrorMessage = "Can't have a blank \nMenu Item Name. Try Again!";
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
            Regex r = new Regex(@"^[0-9]*(\.[0-9]{1,2})?$");
            if (Price.Length > 0)
            {
                if (r.Match(Price).Success)
                {
                    if (Price.Length == 1)
                    {
                        Price += ".00";
                    }
                    PriceTextbox.Text = Price;
                    CorrectPriceFormat = true;
                }
                else
                {
                    ErrorMessage = "Incorrect Format: \nFormat = 0.00";
                    CorrectPriceFormat = false;
                }
            }
            else
            {
                CorrectPriceFormat = false;
                ErrorMessage = "Must Enter a Price";
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
                    double NewPrice = Convert.ToDouble(Price);
                    FoodItem NewItem = new FoodItem(MenuItemId,MenuItemName,NewPrice,RestaurantId);
                    DatabaseHandler.InsertFoodItem(NewItem);
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
            RestAdminMainMenu RAM = new RestAdminMainMenu(AdminId, RestaurantId);
            RAM.ShowDialog();
        }

        private void RestaurantMenuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RestaurantMenuList.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                MenuItemId = Int32.Parse(RestaurantMenuList.SelectedItems[0].Text);
                MenuItemName = RestaurantMenuList.SelectedItems[0].SubItems[1].Text;
                Price = RestaurantMenuList.SelectedItems[0].SubItems[2].Text;
                Price = string.Format("{0:#.00}", Convert.ToDecimal(Price));
                NameTextbox.Text = MenuItemName;
                PriceTextbox.Text = Price;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //remove item from db
            Delete = true;
            MessageBox.Show("Item: " + MenuItemName + " Removed");
        }
    }
}
