using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using cs4227.Meal;
using cs4227.Restaurant;

namespace cs4227.UI
{
    public partial class UserRestarauntSearch : Form
    {
        private bool CorrectNameFormat;
        private string ErrorMessage = "";
        private int RestaurantId;
        private string RestaurantName = "";
        private readonly int UserId;

        public UserRestarauntSearch(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //back
        {
            Hide();
            var UMM = new UserMainMenu(UserId);
            UMM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) //Menu
        {
            var Restaurantfound = false;
            if (CorrectNameFormat)
            {
                var Rest = StaticAccessor.DB.GetRestaurant(0, RestaurantName);
                if (Rest == null){}
                else
                    Restaurantfound = true;

                if (Restaurantfound)
                {
                    RestaurantId = Rest.Id;
                    Hide();
                    var UOM = new UserOrderMenu(UserId, RestaurantId, new Order(), new List<Memento>());
                    UOM.ShowDialog();
                }
                else
                {
                    MessageBox.Show(@"Error: Restaurant Not Found. Select one from the list or Try Search Again.");
                    EnterRestaurantName.Text = @"Enter Restaurant Name: ERROR";
                }
            }
            else
            {
                ErrorMessageLabel.Text = @"Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                EnterRestaurantName.Text = @"Enter Restaurant Name: ERROR";
            }
        }

        private void UserResterauntSearch_Load(object sender, EventArgs e)
        {
            ErrorMessageLabel.Visible = false;
            var restaurants = StaticAccessor.DB.GetRestaurants();
            foreach (var restaurant in restaurants)
            {
                var RestaurantItem = new ListViewItem(restaurant.Name);
                RestaurantItem.SubItems.Add(new ListViewItem.ListViewSubItem(RestaurantItem, "" + restaurant.Id));
                ListOfRestaurants.Items.Add(RestaurantItem);
            }
        }

        private void ListOfRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestaurantId = int.Parse(ListOfRestaurants.SelectedItems[0].SubItems[1].Text);
            Hide();
            var UOM = new UserOrderMenu(UserId, RestaurantId, new Order(), new List<Memento>());
            UOM.ShowDialog();
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantName = SearchTextbox.Text;

            if (RestaurantName.Length > 0)
            {
                if (RestaurantName.Any(char.IsSymbol))
                {
                    ErrorMessage = "Can't use Symbols\n in a Restaurant's Name";
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
                ErrorMessage = "Can't have a blank Restaurant Name. \nTry Again!";
            }

            if (!CorrectNameFormat)
            {
                ErrorMessageLabel.Text = @"Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                EnterRestaurantName.Text = @"Enter Restaurant Name: ERROR";
            }
        }
    }
}