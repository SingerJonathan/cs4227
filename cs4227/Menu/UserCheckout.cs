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
    public partial class UserCheckout : Form
    {
        public UserCheckout()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrderMenu f12 = new UserOrderMenu();
            f12.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
