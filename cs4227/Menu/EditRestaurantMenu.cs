using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace cs4227.Menu
{
    public partial class EditRestaurantMenu : Form
    {
        private int RestaurantId = 0;
        private string RestaurantName = "";
        private string RestaurantAddress = "";
        private string RestaurantOwner = "";
        private string RestaurantPhoneNumber = "";
        private string RestaurantEmail = "";
        private string AdminEmail = "";
        private string RestaurantOpeningHours = "";
        private string RestaurantClosingHours = "";
        private string RestaurantDaysOpen = "";
        private string RestaurantType = "";
        private string RestaurantDeliveryCharge = "";
        private string ErrorMessage = "";
        private Boolean CorrectNameFormat = false;
        private Boolean CorrectAddressFormat = false;
        private Boolean CorrectOwnerFormat = false;
        private Boolean CorrectPhoneNumberFormat = false;
        private Boolean CorrectEmailFormat = false;
        private Boolean CorrectAdminEmailFormat = false;
        private Boolean CorrectOpeningHoursFormat = false;
        private Boolean CorrectClosingHoursFormat = false;
        private Boolean CorrectDaysOpenFormat = false;
        private Boolean CorrectTypeFormat = false;
        private Boolean CorrectDeliveryChargeFormat = false;
        private Boolean newRestaurant = false;
        private Boolean sysAdmin = false;

        public EditRestaurantMenu(int RestaurantId, Boolean newRestaurant, Boolean sysAdmin)
        {
            this.RestaurantId = RestaurantId;
            this.newRestaurant = newRestaurant;
            this.sysAdmin = sysAdmin;
            InitializeComponent();
        }

        private void EditRestaurantMenu_Load(object sender, EventArgs e)
        {
            RestaurantNameTextbox.Text = RestaurantName;
            if (sysAdmin)
            {
                this.Text = "SysAdmin Menu: Edit Restaurant";
            }
            else
            {
                this.Text = "Admin Menu: Edit Restaurant";
            }
        }

        private void RestaurantNameTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantName = RestaurantNameTextbox.Text.ToString();

            if (RestaurantName.Length > 0)
            {

                if (RestaurantName.Any(char.IsSymbol))
                {
                    ErrorMessage = "Can't use Symbols in a Restaurant's Name";
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
                ErrorMessage = "Can't have a blank Restaurant Name. Try Again!";
            }

            if (!CorrectNameFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                RestaurantNameLabel.Text = "Name: ERROR";
            }
            else
            {
                Boolean RestaurantExists = false;

                //Add code to check if the restaurant exists

                if (RestaurantExists)
                {
                    ErrorMessageLabel.Text = "Error Message: Restaurant does not exist";
                    ErrorMessageLabel.Visible = true;
                    RestaurantNameLabel.Text = "Name: ERROR";
                    CorrectNameFormat = false;
                }
                else
                {
                    RestaurantNameLabel.Text = "Name:";
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    CorrectNameFormat = true;
                }
            }
        }

        private void RestaurantAddressTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantAddress = RestaurantAddressTextbox.Text.ToString();

            if (RestaurantAddress.Length > 0)
            {

                if (RestaurantAddress.Any(char.IsSymbol) || RestaurantAddress.Any(char.IsPunctuation)) 
                {
                    ErrorMessage = "Can't use Symbols in a Restaurant's Address";
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
                ErrorMessage = "Can't have a blank Restaurant Address. Try Again!";
            }

            if (!CorrectAddressFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                RestaurantAddressLabel.Text = "Address: ERROR";
            }
            else
            {
                Boolean RestaurantExists = false;

                //Add code to check if the address already exists

                if (RestaurantExists)
                {
                    ErrorMessageLabel.Text = "Error Message: Address Exists Already";
                    ErrorMessageLabel.Visible = true;
                    RestaurantAddressLabel.Text = "Address: ERROR";
                    CorrectAddressFormat = false;
                }
                else
                {
                    RestaurantAddressLabel.Text = "Address:";
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    CorrectAddressFormat = true;
                }
            }
        }

        private void RestaurantOwnerTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantOwner = RestaurantOwnerTextbox.Text.ToString();

            if (RestaurantOwner.Length > 0)
            {
                CorrectOwnerFormat = true;
                if (RestaurantOwner.Any(char.IsDigit))
                {
                    ErrorMessage = "Can't Use Numbers in an Owner's Name";
                    CorrectOwnerFormat = false;
                }

                if (RestaurantOwner.Any(char.IsSymbol) || RestaurantOwner.Any(char.IsPunctuation))
                {
                    ErrorMessage = "Can't Use Symbols in an Owner's Name";
                    CorrectOwnerFormat = false;
                }
            }
            else
            {
                CorrectOwnerFormat = false;
                ErrorMessage = "Can't have a blank Owner's Name. Try Again!";
            }

            if (!CorrectOwnerFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                RestaurantOwnerLabel.Text = "Owner: ERROR";
            }
            else
            {
                RestaurantOwnerLabel.Text = "Owner:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
            }
        }

        private void RestaurantPhoneNumberTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantPhoneNumber = RestaurantPhoneNumberTextbox.Text.ToString();

            if (RestaurantPhoneNumber.Length > 0)
            {
                if (!RestaurantPhoneNumber.All(char.IsDigit))
                {
                    ErrorMessage = "Enter Numbers Only";
                    CorrectPhoneNumberFormat = false;
                }
                else
                {
                    CorrectPhoneNumberFormat = true;
                }
            }
            else
            {
                CorrectPhoneNumberFormat = false;
            }

            if (!CorrectPhoneNumberFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                RestaurantPhoneNumberLabel.Text = "Phone Number: ERROR";
            }
            else
            {
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
                RestaurantPhoneNumberLabel.Text = "Phone Number:";
            }
        }

        private void RestaurantEmailTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantEmail = RestaurantEmailTextbox.Text.ToString();

            if (RestaurantEmail.Length > 0)
            {
                try
                {
                    MailAddress m = new MailAddress(RestaurantEmail);
                    CorrectEmailFormat = true;
                }
                catch (FormatException)
                {

                }
                if (!CorrectEmailFormat)
                {
                    ErrorMessage = "Incorrect Email Format. Try Again!";
                    CorrectEmailFormat = false;
                }
            }
            else
            {
                CorrectEmailFormat = false;
                ErrorMessage = "Can't have a blank Email. Try again!";
            }

            if (!CorrectEmailFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                RestaurantEmailLabel.Text = "Email: ERROR";
            }
            else
            {
                Boolean EmailExists = false;
                //Add code to check if email already exists

                if (!EmailExists)
                {
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    RestaurantEmailLabel.Text = "Email:";
                    CorrectEmailFormat = true;
                }
                else
                {
                    ErrorMessageLabel.Text = "Error Message: Email already exists. Try Again!";
                    ErrorMessageLabel.Visible = true;
                    RestaurantEmailLabel.Text = "Email: ERROR";
                    CorrectEmailFormat = false;
                }
            }
        }

        private void RestaurantOpeningHoursTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantOpeningHours = RestaurantOpeningHoursTextbox.Text.ToString();

            if (RestaurantOpeningHours.Length > 0)
            {
                if (!RestaurantOpeningHours.All(char.IsDigit))
                {
                    ErrorMessage = "Enter Numbers Only \nFormat: 9000 => 9am | 2200 => 10pm";
                    CorrectOpeningHoursFormat = false;
                }
                else
                {
                    CorrectOpeningHoursFormat = true;
                }
            }
            else
            {
                CorrectOpeningHoursFormat = false;
            }

            if (!CorrectOpeningHoursFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                RestaurantOpeningHoursLabel.Text = "Opening Hours: ERROR";
            }
            else
            {
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
                RestaurantOpeningHoursLabel.Text = "Opening Hours:";
            }
        }

        private void RestaurantClosingHoursTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantClosingHours = RestaurantClosingHoursTextbox.Text.ToString();

            if (RestaurantClosingHours.Length > 0)
            {
                if (!RestaurantClosingHours.All(char.IsDigit))
                {
                    ErrorMessage = "Enter Numbers Only \nFormat: 9000 => 9am | 2200 => 10pm";
                    CorrectClosingHoursFormat = false;
                }
                else
                {
                    CorrectClosingHoursFormat = true;
                }
            }
            else
            {
                CorrectClosingHoursFormat = false;
            }

            if (!CorrectClosingHoursFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                RestaurantClosingHoursLabel.Text = "Closing Hours: ERROR";
            }
            else
            {
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
                RestaurantClosingHoursLabel.Text = "Closing Hours:";
            }
        }

        private void RestaurantDaysOpenTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantDaysOpen = RestaurantDaysOpenTextbox.Text.ToString();

            if (RestaurantDaysOpen.Length > 0)
            {
                CorrectDaysOpenFormat = true;
                if (RestaurantDaysOpen.Any(char.IsDigit))
                {
                    ErrorMessage = "Can't Use Numbers in Days Open";
                    CorrectDaysOpenFormat = false;
                }

                if (RestaurantDaysOpen.Any(char.IsSymbol) || RestaurantDaysOpen.Any(char.IsPunctuation))
                {
                    ErrorMessage = "Can't Use Symbols in Days Open";
                    CorrectDaysOpenFormat = false;
                }
            }
            else
            {
                CorrectDaysOpenFormat = false;
                ErrorMessage = "Can't have a blank Days Open. Try Again! \nFormat: Day + space + Day => Monday Tuesday";
            }

            if (!CorrectDaysOpenFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                RestaurantDaysOpenLabel.Text = "Days Open: ERROR";
            }
            else
            {
                RestaurantDaysOpenLabel.Text = "Days Open:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
            }
        }

        private void RestaurantTypeTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantType = RestaurantTypeTextbox.Text.ToString();

            if (RestaurantType.Length > 0)
            {
                CorrectTypeFormat = true;
                if (RestaurantType.Any(char.IsDigit))
                {
                    ErrorMessage = "Can't Use Numbers in Type of Restaurant";
                    CorrectTypeFormat = false;
                }

                if (RestaurantType.Any(char.IsSymbol) || RestaurantType.Any(char.IsPunctuation))
                {
                    ErrorMessage = "Can't Use Symbols in Type of Restaurant";
                    CorrectTypeFormat = false;
                }
            }
            else
            {
                CorrectTypeFormat = false;
                ErrorMessage = "Can't have a blank Type of Restaurant. Try Again!";
            }

            if (!CorrectTypeFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                RestaurantTypeLabel.Text = "Type: ERROR";
            }
            else
            {
                RestaurantTypeLabel.Text = "Type:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
            }
        }

        private void RestaurantDeliveryChargeTextbox_TextChanged(object sender, EventArgs e)
        {
            RestaurantDeliveryCharge = RestaurantDeliveryChargeTextbox.Text.ToString();

            if (RestaurantDeliveryCharge.Length > 0)
            {
                if (!RestaurantDeliveryCharge.Any(char.IsDigit) || !RestaurantDeliveryCharge.Any(char.IsWhiteSpace))
                {
                    ErrorMessage = "Enter Numbers Only \nFormat: 2 00 => €2.00";
                    CorrectDeliveryChargeFormat = false;
                }
                else
                {
                    CorrectDeliveryChargeFormat = true;
                }
            }
            else
            {
                CorrectDeliveryChargeFormat = false;
            }

            if (!CorrectDeliveryChargeFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                RestaurantDeliveryChargeLabel.Text = "Delivery Charge: ERROR";
            }
            else
            {
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
                RestaurantDeliveryChargeLabel.Text = "Delivery Charge:";
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if(CorrectNameFormat && CorrectAddressFormat && CorrectOwnerFormat && CorrectPhoneNumberFormat && CorrectEmailFormat && CorrectOpeningHoursFormat && CorrectClosingHoursFormat && CorrectDaysOpenFormat && CorrectTypeFormat && CorrectDeliveryChargeFormat && CorrectAdminEmailFormat)
            {
                //Add code to save restaurant 

                if (sysAdmin)
                {
                    this.Hide();
                    SysViewRestaraunt SVR = new SysViewRestaraunt(RestaurantId);
                    SVR.ShowDialog();
                }
                else
                {
                    this.Hide();
                    RestAdminMenu RM = new RestAdminMenu(RestaurantId);
                    RM.ShowDialog();
                }
            }
            else
            {
                ErrorMessageLabel.Text = "Error Message: Please Fix Any Issues with the Restaurant's details";
                ErrorMessageLabel.Visible = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (sysAdmin)
            {
                if (newRestaurant)
                {
                    this.Hide();
                    SysAdminRestaurantsMenu SRM = new SysAdminRestaurantsMenu();
                    SRM.ShowDialog();
                }
                else
                {
                    this.Hide();
                    SysViewRestaraunt SVR = new SysViewRestaraunt(RestaurantId);
                    SVR.ShowDialog();
                }
            }
            else
            {
                this.Hide();
                RestAdminMenu RM = new RestAdminMenu(RestaurantId);
                RM.ShowDialog();
            }
        }

        private void AdminEmailTextbox_TextChanged(object sender, EventArgs e)
        {
            AdminEmail = AdminEmailTextbox.Text.ToString();

            if (AdminEmail.Length > 0)
            {
                try
                {
                    MailAddress m = new MailAddress(AdminEmail);
                    CorrectEmailFormat = true;
                }
                catch (FormatException)
                {

                }
                if (!CorrectEmailFormat)
                {
                    ErrorMessage = "Incorrect Email Format. Try Again!";
                    CorrectAdminEmailFormat = false;
                }
            }
            else
            {
                CorrectAdminEmailFormat = false;
                ErrorMessage = "Can't have a blank Email. Try again!";
            }

            if (!CorrectAdminEmailFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AdminEmailLabel.Text = "Email: ERROR";
            }
            else
            {
                Boolean AdminEmailExists = false;
                //Add code to check if email already exists

                if (!AdminEmailExists)
                {
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    AdminEmailLabel.Text = "Admin Email:";
                    CorrectAdminEmailFormat = true;
                }
                else
                {
                    ErrorMessageLabel.Text = "Error Message: Email already exists. Try Again!";
                    ErrorMessageLabel.Visible = true;
                    AdminEmailLabel.Text = "Admin Email: ERROR";
                    CorrectAdminEmailFormat = false;
                }
            }
        }
    }
}
