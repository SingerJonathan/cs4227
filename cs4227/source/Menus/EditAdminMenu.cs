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

namespace cs4227.source.Menus
{
    public partial class EditAdminMenu : Form
    {
        private string AdminEmail = "";
        private string AdminName = "";
        private string AdminUsername = "";
        private string AdminPassword = "";
        private string AdminRestaurant = "";
        private string ErrorMessage = "";
        private Boolean CorrectEmailFormat = false;
        private Boolean CorrectNameFormat = false;
        private Boolean CorrectUsernameFormat = false;
        private Boolean CorrectPasswordFormat = false;
        private Boolean CorrectRestaurantFormat = false;

        public EditAdminMenu(string AdminEmail)
        {
            this.AdminEmail = AdminEmail;
            InitializeComponent();
        }

        private void EditAdminMenu_Load(object sender, EventArgs e)
        {
            AdminEmailTextbox.Text = AdminEmail;
            CorrectEmailFormat = true;
            ErrorMessageLabel.Visible = false;

            //Add code to display currently existing Admin details etc..
        }

        private void AdminNameTextbox_TextChanged(object sender, EventArgs e)
        {
            AdminName = AdminNameTextbox.Text.ToString();

            if (AdminName.Length > 0)
            {
                CorrectNameFormat = true;
                if (AdminName.Any(char.IsDigit))
                {
                    ErrorMessage = "Can't Use Numbers in a Name";
                    CorrectNameFormat = false;
                }

                if (AdminName.Any(char.IsSymbol) || AdminName.Any(char.IsPunctuation))
                {
                    ErrorMessage = "Can't Use Symbols in a Name";
                    CorrectNameFormat = false;
                }
            }
            else
            {
                CorrectNameFormat = false;
                ErrorMessage = "Can't have a blank Name. Try Again!";
            }

            if (!CorrectNameFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AdminNameLabel.Text = "Name: ERROR";
            }
            else
            {
                AdminNameLabel.Text = "Name:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
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
                AdminEmailLabel.Text = "Email: ERROR";
            }
            else
            {
                Boolean EmailExists = false;
                //Add code to check if email already exists

                if (!EmailExists)
                {
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    AdminEmailLabel.Text = "Email:";
                    CorrectEmailFormat = true;
                }
                else
                {
                    ErrorMessageLabel.Text = "Error Message: Email already exists. Try Again!";
                    ErrorMessageLabel.Visible = true;
                    AdminEmailLabel.Text = "Email: ERROR";
                    CorrectEmailFormat = false;
                }
            }
        }

        private void AdminUsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            AdminUsername = AdminUsernameTextbox.Text.ToString();

            if (AdminUsername.Length > 0)
            {
                if (AdminUsername.Any(char.IsPunctuation) || AdminUsername.Any(char.IsWhiteSpace))
                {
                    CorrectUsernameFormat = false;
                    ErrorMessage = "Can't Use Spaces or Punctuation for an Username";
                }
                else
                {
                    CorrectUsernameFormat = true;
                }
            }
            else
            {
                CorrectUsernameFormat = false;
                ErrorMessage = "Can't have a blank Username. Try Again!";
            }

            if (!CorrectUsernameFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AdminUsernameLabel.Text = "Username: ERROR";
            }
            else
            {
                Boolean UsernameExists = false;
                //Add code to check if username exists already

                if (!UsernameExists)
                {
                    AdminUsernameLabel.Text = "Username:";
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                }
                else
                {
                    ErrorMessageLabel.Text = "Error Message: Username already exists. Try Again!";
                    ErrorMessageLabel.Visible = true;
                    AdminUsernameLabel.Text = "Username: ERROR";
                    CorrectUsernameFormat = false;
                }
            }
        }

        private void AdminPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            AdminPassword = AdminPasswordTextbox.Text.ToString();

            if (AdminPassword.Length > 4)
            {
                if (!AdminPassword.Any(char.IsUpper))
                {
                    CorrectPasswordFormat = false;
                    ErrorMessage = "Passwords must contain an Upper Case letter";
                }
                else if (!AdminPassword.Any(char.IsLower))
                {
                    CorrectPasswordFormat = false;
                    ErrorMessage = "Passwords must contain a Lower Case letter";
                }
                else if (!AdminPassword.Any(char.IsDigit))
                {
                    CorrectPasswordFormat = false;
                    ErrorMessage = "Passwords must contain a Number";
                }
                else if (!AdminPassword.Any(char.IsSymbol) && !AdminPassword.Any(char.IsPunctuation))
                {
                    CorrectPasswordFormat = false;
                    ErrorMessage = "Passwords must contain a Symbol";
                }
                else
                {
                    CorrectPasswordFormat = true;
                }
            }
            else
            {
                CorrectPasswordFormat = false;
                ErrorMessage = "Passwords Must be Longer than 4 characters. Try Again!";
            }

            if (!CorrectPasswordFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AdminPasswordLabel.Text = "Password: ERROR";
            }
            else
            {
                AdminPasswordLabel.Text = "Password:";
                ErrorMessage = "";
                ErrorMessageLabel.Visible = false;
            }
        }

        private void AdminRestaurantTextbox_TextChanged(object sender, EventArgs e)
        {
            AdminRestaurant = AdminRestaurantTextbox.Text.ToString();

            if (AdminRestaurant.Length > 0)
            {

                if (AdminRestaurant.Any(char.IsSymbol))
                {
                    ErrorMessage = "Can't use Symbols in a Restaurant's Name";
                    CorrectRestaurantFormat = false;
                }
                else
                {
                    CorrectRestaurantFormat = true;
                }
            }
            else
            {
                CorrectRestaurantFormat = false;
                ErrorMessage = "Can't have a blank Restaurant Name. Try Again!";
            }

            if (!CorrectRestaurantFormat)
            {
                ErrorMessageLabel.Text = "Error Message: " + ErrorMessage;
                ErrorMessageLabel.Visible = true;
                AdminRestaurantLabel.Text = "Restaurant: ERROR";
            }
            else
            {
                Boolean RestaurantExists = true;
                Boolean AdminExists = false;

                //Add code to check if the restaurant exists

                //Add code to check if admin already exists for that restaurant

                if (!RestaurantExists)
                {
                    ErrorMessageLabel.Text = "Error Message: Restaurant does not exist";
                    ErrorMessageLabel.Visible = true;
                    AdminRestaurantLabel.Text = "Restaurant: ERROR";
                    CorrectRestaurantFormat = false;
                }
                else if (AdminExists)
                {
                    ErrorMessageLabel.Text = "Error Message: An Admin already exists for this restaurant";
                    ErrorMessageLabel.Visible = true;
                    AdminRestaurantLabel.Text = "Restaurant: ERROR";
                    CorrectRestaurantFormat = false;
                }
                else
                {
                    AdminRestaurantLabel.Text = "Restaurant:";
                    ErrorMessage = "";
                    ErrorMessageLabel.Visible = false;
                    CorrectRestaurantFormat = true;
                }
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (CorrectEmailFormat && CorrectNameFormat && CorrectUsernameFormat && CorrectPasswordFormat && CorrectRestaurantFormat)
            {
                //add code to save for an existing admin

                //Enter Code to handle saving new Admin

                this.Hide();
                SysAdminAdminsMenu SAAM = new SysAdminAdminsMenu();
                SAAM.ShowDialog(); 
            }
            else
            {
                ErrorMessageLabel.Text = "Error Message: Please Fix Any Issues with the Admin's details";
                ErrorMessageLabel.Visible = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysAdminAdminsMenu SAAM = new SysAdminAdminsMenu();
            SAAM.ShowDialog();
        }
    }
}
