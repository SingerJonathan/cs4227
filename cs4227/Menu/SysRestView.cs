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
    public partial class SysViewRestaraunt : Form
    {
        private int RestaurantId = 0;

        public SysViewRestaraunt(int RestaurantId)
        {
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysViewOrder SVO = new SysViewOrder(RestaurantId);
            SVO.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysViewMenu SVM = new SysViewMenu(RestaurantId);
            SVM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysViewMenuItems SVMI = new SysViewMenuItems(RestaurantId);
            SVMI.ShowDialog();
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
            EditRestaurantMenu ERM = new EditRestaurantMenu(RestaurantId, false, true);
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
