using System;
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
    public partial class SysViewRestaraunt : Form
    {
        private string RestaurantName = "";

        public SysViewRestaraunt(string RestaurantName)
        {
            this.RestaurantName = RestaurantName;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysViewOrder f2 = new SysViewOrder(RestaurantName);
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysViewMenu f3 = new SysViewMenu(RestaurantName);
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysViewMenuItems f4 = new SysViewMenuItems(RestaurantName);
            f4.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EditRestaurantButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditRestaurantMenu ERM = new EditRestaurantMenu(RestaurantName, false);
            ERM.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysAdminRestaurantsMenu SRM = new SysAdminRestaurantsMenu();
            SRM.ShowDialog();
        }
    }
}
