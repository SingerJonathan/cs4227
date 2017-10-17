﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs4227.source.Menus
{
    public partial class SysAdminRestaurantsMenu : Form
    {
        private string RestaurantName = "";
        private string ErrorMessage = "";
        private Boolean CorrectNameFormat = false;

        public SysAdminRestaurantsMenu()
        {
            InitializeComponent();
        }

        private void ListOfRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestaurantName = ListOfRestaurants.SelectedItems[0].Text.ToString();
            this.Hide();
            SysViewRestaraunt SVR = new SysViewRestaraunt(RestaurantName);
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
                ListViewItem Restaurant = new ListViewItem();
                Restaurant.Text = RestaurantName;
                ListOfRestaurants.Items.Add(Restaurant);
                ListOfRestaurants.Update();
                this.Hide();
                EditRestaurantMenu ERM = new EditRestaurantMenu(RestaurantName, true);
                ERM.ShowDialog();
            }
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysAdminMenu SAM = new SysAdminMenu();
            SAM.ShowDialog();
        }
    }
}
