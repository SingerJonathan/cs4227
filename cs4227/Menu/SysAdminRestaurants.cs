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

namespace cs4227.Menu
{
    public partial class SysAdminRestaurantsMenu : Form
    {
        private int RestaurantId = 0;
        private int UserId = 0;
        private string RestaurantName = "";
        private string ErrorMessage = "";
        private Boolean CorrectNameFormat = false;

        public SysAdminRestaurantsMenu(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void ListOfRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestaurantName = ListOfRestaurants.SelectedItems[0].Text.ToString();
            RestaurantId = Int32.Parse(ListOfRestaurants.SelectedItems[0].SubItems[1].Text);
            this.Hide();
            SysViewRestaraunt SVR = new SysViewRestaraunt(UserId, RestaurantId);
            SVR.ShowDialog();

        }

        private void RestaurantNameTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantName = RestaurantNameTextbox.Text.ToString();

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
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                RestaurantNameLabel.Text = "Enter Restaurant Name: ERROR";
            }
            else
            {
                Boolean RestaurantExists = false;

                //Add code to check if the restaurant exists

                if (RestaurantExists)
                {
                    ErrorMessageLabel.Text = "Error Message: Restaurant does not exist";
                    ErrorMessageLabel.Visible = true;
                    RestaurantNameLabel.Text = "Enter Restaurant Name: ERROR";
                    CorrectNameFormat = false;
                }
                else
                {
                    RestaurantNameLabel.Text = "Enter Restaurant Name:";
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    CorrectNameFormat = true;
                }
            }
        }

        private void AddRestaurantButton_Click(object sender, EventArgs e)
        {
            if (CorrectNameFormat)
            {
                //add code to add correct Restaurantid ---list.length()+1 etc...
                
                this.Hide();
                EditRestaurantMenu ERM = new EditRestaurantMenu(UserId, RestaurantId, true, true, RestaurantNameTextbox.Text);
                ERM.ShowDialog();
            }
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysAdminMenu SAM = new SysAdminMenu(UserId);
            SAM.ShowDialog();
        }

        private void SysAdminRestaurantsMenu_Load(object sender, EventArgs e)
        {
            List<Restaurant.Restaurant> restaurants = DatabaseHandler.GetRestaurants();
            foreach (Restaurant.Restaurant restaurant in restaurants)
            {
                ListViewItem restaurantItem = new ListViewItem(restaurant.Name);
                restaurantItem.SubItems.Add(new ListViewItem.ListViewSubItem(restaurantItem, "" + restaurant.Id));
                ListOfRestaurants.Items.Add(restaurantItem);
            }
        }
    }
}
