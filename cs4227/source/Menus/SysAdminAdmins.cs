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
    public partial class SysAdminAdminsMenu : Form
    {
        private string AdminEmail = "";
        private string ErrorMessage = "";
        private Boolean CorrectEmailFormat = false;

        public SysAdminAdminsMenu()
        {
            InitializeComponent();
        }

        private void AdminsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminEmail = AdminsList.SelectedItems[0].Text.ToString();
            this.Hide();
            EditAdminMenu EAM = new EditAdminMenu(AdminEmail);
            EAM.ShowDialog();
            AdminEmail = "";
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

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            if (CorrectEmailFormat)
            {
                this.Hide();
                EditAdminMenu EAM = new EditAdminMenu(AdminEmail);
                EAM.ShowDialog();
            }
            else
            {
                ErrorMessageLabel.Text = "Error Message: Please Fix Any Issues with the Admin's Email";
                ErrorMessageLabel.Visible = true;
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
