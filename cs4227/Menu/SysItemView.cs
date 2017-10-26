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
    public partial class SysViewMenuItems : Form
    {
        private int RestaurantId = 0;

        public SysViewMenuItems(int RestaurantId)
        {
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysViewRestaraunt SVR = new SysViewRestaraunt(RestaurantId);
            SVR.ShowDialog();
        }
    }
}
