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
    public partial class SysViewMenu : Form
    {
        private string RestaurantName = "";

        public SysViewMenu(string RestaurantName)
        {
            this.RestaurantName = RestaurantName;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysViewRestaraunt f1 = new SysViewRestaraunt(RestaurantName);
            f1.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
