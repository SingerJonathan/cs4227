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
    public partial class SysViewMenuItems : Form
    {
        private string RestaurantName = "";

        public SysViewMenuItems(string RestaurantName)
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
    }
}
