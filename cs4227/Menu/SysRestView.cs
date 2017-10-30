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

namespace cs4227.Menu
{
    public partial class SysViewRestaraunt : Form
    {
        private int RestaurantId = 0;
        private int AdminId = 0;

        public SysViewRestaraunt(int AdminId, int RestaurantId)
        {
            this.AdminId = AdminId;
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysViewOrder SVO = new SysViewOrder(AdminId, RestaurantId);
            SVO.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysViewMenu SVM = new SysViewMenu(AdminId, RestaurantId);
            SVM.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Restaurant.Restaurant Rest = DatabaseHandler.GetRestaurant(RestaurantId);
            RestaurantNameLabel.Text = "Restaurant: " + Rest.Name;
        }

        private void EditRestaurantButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditRestaurantMenu ERM = new EditRestaurantMenu(AdminId, RestaurantId, false, true);
            ERM.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysAdminRestaurantsMenu SRM = new SysAdminRestaurantsMenu(AdminId);
            SRM.ShowDialog();
        }
    }
}
