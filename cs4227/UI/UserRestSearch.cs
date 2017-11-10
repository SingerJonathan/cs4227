using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cs4227.Database;
using cs4227.Restaurant;

namespace cs4227.UI
{
    public partial class UserRestarauntSearch : Form
    {
        private int UserId = 0;
        private int RestaurantId = 0;
        private string RestaurantName = "";
        private string ErrorMessage = "";
        private Boolean CorrectNameFormat = false;

        public UserRestarauntSearch(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //back
        {
            this.Hide();
            UserMainMenu UMM = new UserMainMenu(UserId);
            UMM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) //Menu
        {
            if (CorrectNameFormat)
            {
                Boolean Restaurantfound = false;
                Restaurant.Restaurant Rest = StaticAccessor.DB.GetRestaurant(0, RestaurantName);
                if (Rest == null)
                {
                    Restaurantfound = false;
                }
                else
                {
                    Restaurantfound = true;
                }

                if (Restaurantfound)
                {
                    RestaurantId = Rest.Id;
                    this.Hide();
                    UserOrderMenu UOM = new UserOrderMenu(UserId, RestaurantId, new Order(), new List<Meal.Memento>());
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
            List<Restaurant.Restaurant> restaurants = StaticAccessor.DB.GetRestaurants();
            foreach (Restaurant.Restaurant restaurant in restaurants)
            {
                ListViewItem RestaurantItem = new ListViewItem(restaurant.Name);
                RestaurantItem.SubItems.Add(new ListViewItem.ListViewSubItem(RestaurantItem, "" + restaurant.Id));
                ListOfRestaurants.Items.Add(RestaurantItem);
            }
        }

        private void ListOfRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestaurantId = Int32.Parse(ListOfRestaurants.SelectedItems[0].SubItems[1].Text);
            this.Hide();
            UserOrderMenu UOM = new UserOrderMenu(UserId, RestaurantId, new Order(), new List<Meal.Memento>());
            UOM.ShowDialog();
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantName = SearchTextbox.Text.ToString();

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
