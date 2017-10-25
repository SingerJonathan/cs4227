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
    public partial class UserOrderHistory : Form
    {
        public UserOrderHistory()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMenu f7 = new UserMenu();
            f7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrderMenu f12 = new UserOrderMenu();
            f12.ShowDialog();
        }
    }
}
