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
        private double BronzeDiscountValue = 0.0;
        private double SilverDiscountValue = 0.0;
        private double GoldDiscountValue = 0.0;
        private string ErrorMessage = "";
        private Boolean CorrectNameFormat = false;
        private Boolean CorrectPriceFormat = false;
        private Boolean CorrectBronzeFormat = false;
        private Boolean CorrectSilverFormat = false;
        private Boolean CorrectGoldFormat = false;

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
                string bronze = Food.Discounts[1].ToString();
                if (bronze.Length == 1 || bronze.Length == 2)
                {
                    bronze += ".00";
                }
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + bronze));
                string silver = Food.Discounts[2].ToString();
                if (silver.Length == 1 || silver.Length == 2)
                {
                    silver += ".00";
                }
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + silver));
                string gold = Food.Discounts[3].ToString();
                if (gold.Length == 1 || gold.Length == 2)
                {
                    gold += ".00";
                }
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + gold));
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
                    if (Price.Length == 1 || Price.Length == 2)
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
            if (BronzeDiscountTextbox.Text == "0.00")
                CorrectBronzeFormat = true;
            if (SilverDiscountTextbox.Text == "0.00")
                CorrectSilverFormat = true;
            if (GoldDiscountTextbox.Text == "0.00")
                CorrectGoldFormat = true;


            if (CorrectNameFormat && CorrectPriceFormat && CorrectBronzeFormat && CorrectSilverFormat && CorrectGoldFormat)
            {
                //check if item exists already
                ErrorMessageLabel.Visible = false;
                Boolean Exists = false;
                if (!Exists)
                {
                    //add to db
                    double NewPrice = Convert.ToDouble(Price);
                    FoodItem NewItem = new FoodItem(MenuItemId, MenuItemName, NewPrice, RestaurantId, BronzeDiscountValue, SilverDiscountValue, GoldDiscountValue, false);
                    DatabaseHandler.InsertFoodItem(NewItem);
                    MessageBox.Show("Item:" + MenuItemName + " Added");
                    this.Hide();
                    RestAdminViewMenu RAVM = new RestAdminViewMenu(AdminId,RestaurantId);
                    RAVM.ShowDialog();

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
                BronzeDiscountTextbox.Text = RestaurantMenuList.SelectedItems[0].SubItems[3].Text;
                SilverDiscountTextbox.Text = RestaurantMenuList.SelectedItems[0].SubItems[4].Text;
                GoldDiscountTextbox.Text = RestaurantMenuList.SelectedItems[0].SubItems[5].Text;
                NameTextbox.Text = MenuItemName;
                PriceTextbox.Text = Price;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //remove item from db
            double NewPrice = Convert.ToDouble(Price);
            FoodItem ItemToDelete = new FoodItem(MenuItemId, MenuItemName, NewPrice, RestaurantId, BronzeDiscountValue, SilverDiscountValue, GoldDiscountValue, true);
            DatabaseHandler.UpdateFoodItem(ItemToDelete);
            MessageBox.Show("Item: " + MenuItemName + " Removed");
            this.Hide();
            RestAdminViewMenu RAVM = new RestAdminViewMenu(AdminId, RestaurantId);
            RAVM.ShowDialog();
        }

        private void EditItemButton_Click(object sender, EventArgs e)
        {
            if (BronzeDiscountTextbox.Text == "0.00")
                CorrectBronzeFormat = true;
            if (SilverDiscountTextbox.Text == "0.00")
                CorrectSilverFormat = true;
            if (GoldDiscountTextbox.Text == "0.00")
                CorrectGoldFormat = true;

            if (CorrectNameFormat && CorrectPriceFormat && CorrectBronzeFormat && CorrectSilverFormat && CorrectGoldFormat)
            {
                ErrorMessageLabel.Visible = false;
                double NewPrice = Convert.ToDouble(Price);
                FoodItem NewItem = new FoodItem(MenuItemId, MenuItemName, NewPrice, RestaurantId, BronzeDiscountValue, SilverDiscountValue, GoldDiscountValue, false);
                DatabaseHandler.UpdateFoodItem(NewItem);
                MessageBox.Show("Item: " + MenuItemName + " edited");
                this.Hide();
                RestAdminViewMenu RAVM = new RestAdminViewMenu(AdminId, RestaurantId);
                RAVM.ShowDialog();
            }
            else
            {
                ErrorMessageLabel.Visible = true;
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
            }
        }

        private void BronzeDiscountTextbox_TextChanged(object sender, EventArgs e)
        {
            string Bronze = BronzeDiscountTextbox.Text;
            BronzeDiscountValue = Convert.ToDouble(Bronze);
            Regex r = new Regex(@"^[0-9]*(\.[0-9]{1,2})?$");
            if (Bronze.Length > 0)
            {
                if (r.Match(Bronze).Success)
                {
                    if (Bronze.Length == 1 || Bronze.Length == 2)
                    {
                        Bronze += ".00";
                    }
                    BronzeDiscountTextbox.Text = Bronze;
                    CorrectBronzeFormat = true;
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
                BronzeDiscountLabel.Text = "Bronze Discount: ERROR";
            }
            else
            {
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
                BronzeDiscountLabel.Text = "Bronze Discount:";
            }
        }

        private void SilverDiscountTextbox_TextChanged(object sender, EventArgs e)
        {
            string Silver = SilverDiscountTextbox.Text;
            SilverDiscountValue = Convert.ToDouble(Silver);
            Regex r = new Regex(@"^[0-9]*(\.[0-9]{1,2})?$");
            if (Silver.Length > 0)
            {
                if (r.Match(Silver).Success)
                {
                    if (Silver.Length == 1 || Silver.Length == 2)
                    {
                        Silver += ".00";
                    }
                    SilverDiscountTextbox.Text = Silver;
                    CorrectSilverFormat = true;
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
                SilverDiscountLabel.Text = "Silver Discount: ERROR";
            }
            else
            {
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
                SilverDiscountLabel.Text = "Silver Discount:";
            }
        }

        private void GoldDiscountTextbox_TextChanged(object sender, EventArgs e)
        {
            string Gold = GoldDiscountTextbox.Text;
            GoldDiscountValue = Convert.ToDouble(Gold);
            Regex r = new Regex(@"^[0-9]*(\.[0-9]{1,2})?$");
            if (Gold.Length > 0)
            {
                if (r.Match(Gold).Success)
                {
                    if (Gold.Length == 1 || Gold.Length == 2)
                    {
                        Gold += ".00";
                    }
                    GoldDiscountTextbox.Text = Gold;
                    CorrectGoldFormat = true;
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
                GoldDiscountLabel.Text = "Gold Discount: ERROR";
            }
            else
            {
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
                GoldDiscountLabel.Text = "Gold Discount:";
            }
        }
    }
}
