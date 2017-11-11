using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using cs4227.Restaurant;

namespace cs4227.UI
{
    public partial class RestAdminViewMenu : Form
    {
        private readonly int AdminId;
        private string Bronze = "0.00";
        private double BronzeDiscountValue;
        private bool CorrectBronzeFormat;
        private bool CorrectNameFormat;
        private bool CorrectPriceFormat;
        private string ErrorMessage = "";
        private string Gold = "0.00";
        private double GoldDiscountValue;
        private int MenuItemId;
        private string MenuItemName = "";
        private string Price = "0.00";
        private readonly int RestaurantId;
        private string Silver = "0.00";
        private double SilverDiscountValue;

        public RestAdminViewMenu(int AdminId, int RestaurantId)
        {
            this.AdminId = AdminId;
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void RestAdminViewMenu_Load(object sender, EventArgs e)
        {
            PriceTextbox.Text = Price;
            var FoodItems = StaticAccessor.DB.GetFoodItems(RestaurantId);
            foreach (var Food in FoodItems)
            {
                var row = new ListViewItem("" + Food.Id);
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + Food.Name));
                row.SubItems.Add(
                    new ListViewItem.ListViewSubItem(row, "" + StaticAccessor.DoubleToMoneyString(Food.Cost)));
                var bronze = StaticAccessor.DoubleToMoneyString(Math.Round(Food.Discounts[1], 2));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + bronze));
                var silver = StaticAccessor.DoubleToMoneyString(Math.Round(Food.Discounts[2], 2));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + silver));
                var gold = StaticAccessor.DoubleToMoneyString(Math.Round(Food.Discounts[3], 2));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + gold));
                RestaurantMenuList.Items.Add(row);
            }
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            MenuItemName = NameTextbox.Text;

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
            Price = PriceTextbox.Text;
            var r = new Regex(@"^[0-9]*(\.[0-9]{1,2})?$");
            if (Price.Length > 0)
            {
                if (r.Match(Price).Success)
                {
                    if (Price.Length == 1 || Price.Length == 2)
                        Price += ".00";
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
            if (BronzeDiscountValue < 0)
            {
                BronzeDiscountValue = 0.0;
                BronzeDiscountTextbox.Text = "0.00";
            }
            if (BronzeDiscountTextbox.Text == "0.00")
                CorrectBronzeFormat = true;


            if (CorrectNameFormat && CorrectPriceFormat && CorrectBronzeFormat)
            {
                //check if item exists already
                ErrorMessageLabel.Visible = false;
                    //add to db
                    var NewPrice = Convert.ToDouble(Price);
                    var NewItem = new FoodItem(MenuItemId, MenuItemName, NewPrice, RestaurantId, BronzeDiscountValue,
                        SilverDiscountValue, GoldDiscountValue, false);
                    StaticAccessor.DB.InsertFoodItem(NewItem);
                    MessageBox.Show("Item:" + MenuItemName + " Added");
                    Hide();
                    var RAVM = new RestAdminViewMenu(AdminId, RestaurantId);
                    RAVM.ShowDialog();
            }
            else
            {
                ErrorMessageLabel.Visible = true;
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            var RAM = new RestAdminMainMenu(AdminId, RestaurantId);
            RAM.ShowDialog();
        }

        private void RestaurantMenuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RestaurantMenuList.SelectedItems.Count == 0)
            {
            }
            else
            {
                MenuItemId = int.Parse(RestaurantMenuList.SelectedItems[0].Text);
                MenuItemName = RestaurantMenuList.SelectedItems[0].SubItems[1].Text;
                Price = RestaurantMenuList.SelectedItems[0].SubItems[2].Text;
                Price = string.Format("{0:#.00}", Convert.ToDecimal(Price));
                BronzeDiscountTextbox.Text = RestaurantMenuList.SelectedItems[0].SubItems[3].Text;
                SilverDiscountLabel.Text = "Silver Discount: " + RestaurantMenuList.SelectedItems[0].SubItems[4].Text;
                GoldDiscountLabel.Text = "Gold Discount: " + RestaurantMenuList.SelectedItems[0].SubItems[5].Text;
                NameTextbox.Text = MenuItemName;
                PriceTextbox.Text = Price;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //remove item from db
            var NewPrice = Convert.ToDouble(Price);
            var ItemToDelete = new FoodItem(MenuItemId, MenuItemName, NewPrice, RestaurantId, BronzeDiscountValue,
                SilverDiscountValue, GoldDiscountValue, true);
            StaticAccessor.DB.UpdateFoodItem(ItemToDelete);
            MessageBox.Show("Item: " + MenuItemName + " Removed");
            Hide();
            var RAVM = new RestAdminViewMenu(AdminId, RestaurantId);
            RAVM.ShowDialog();
        }

        private void EditItemButton_Click(object sender, EventArgs e)
        {
            if (BronzeDiscountValue < 0)
            {
                BronzeDiscountValue = 0.0;
                BronzeDiscountTextbox.Text = "0.00";
            }
            if (BronzeDiscountTextbox.Text == "0.00")
                CorrectBronzeFormat = true;

            if (CorrectNameFormat && CorrectPriceFormat && CorrectBronzeFormat)
            {
                ErrorMessageLabel.Visible = false;
                var NewPrice = Convert.ToDouble(Price);
                var NewItem = new FoodItem(MenuItemId, MenuItemName, NewPrice, RestaurantId, BronzeDiscountValue,
                    SilverDiscountValue, GoldDiscountValue, false);
                StaticAccessor.DB.UpdateFoodItem(NewItem);
                MessageBox.Show("Item: " + MenuItemName + " edited");
                Hide();
                var RAVM = new RestAdminViewMenu(AdminId, RestaurantId);
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
            Bronze = BronzeDiscountTextbox.Text;
            var r = new Regex(@"^[0-9]*(\.[0-9]{1,2})?$");
            if (Bronze.Length > 0)
            {
                if (r.Match(Bronze).Success)
                {
                    if (Bronze.Length == 1 || Bronze.Length == 2)
                        Bronze += ".00";
                    BronzeDiscountTextbox.Text = Bronze;
                    CorrectBronzeFormat = true;
                }
                else
                {
                    ErrorMessage = "Incorrect Format: \nFormat = 0.00";
                    CorrectBronzeFormat = false;
                }
            }
            else
            {
                CorrectBronzeFormat = false;
                ErrorMessage = "Must Enter a Discount";
                BronzeDiscountTextbox.Text = "0.00";
            }

            if (!CorrectBronzeFormat)
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
                BronzeDiscountValue = Math.Round(Convert.ToDouble(Bronze), 2);
                SilverDiscountValue = Math.Round(BronzeDiscountValue * 1.30, 2);
                SilverDiscountLabel.Text = "Silver Discount: " + SilverDiscountValue;
                if (BronzeDiscountValue == 0.0)
                    SilverDiscountLabel.Text = "Silver Discount: 0.00";
                Silver = SilverDiscountValue.ToString();
                GoldDiscountValue = Math.Round(BronzeDiscountValue * 1.60, 2);
                GoldDiscountLabel.Text = "Gold Discount: " + GoldDiscountValue;
                Gold = GoldDiscountValue.ToString();
                if (BronzeDiscountValue == 0.0)
                {
                    SilverDiscountLabel.Text = "Silver Discount: 0.00";
                    GoldDiscountLabel.Text = "Gold Discount: 0.00";
                }
            }
        }
    }
}