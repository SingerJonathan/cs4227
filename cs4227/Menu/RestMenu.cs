using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs4227.Menu
{
    public partial class RestMenu : Form
    {
        private string RestaurantName = "";

        public RestMenu(string RestaurantName)
        {
            this.RestaurantName = RestaurantName;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //AddMenuItem
        {

        }

        private void button2_Click(object sender, EventArgs e) //ChangeRestaurantDetails
        {
            this.Hide();
            EditRestaurantMenu ERM = new EditRestaurantMenu(RestaurantName, false, false);
            ERM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) //AddUsertoIgnoreList
        {

        }

        private void button4_Click(object sender, EventArgs e) //ManageOrder
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMenu LM = new LoginMenu();
            LM.ShowDialog();
        }

        private void RestMenu_Load(object sender, EventArgs e)
        {
            RestaurantAdminMessageLabel.Text = "Restaurant Name: " + RestaurantName;
        }
    }
}
