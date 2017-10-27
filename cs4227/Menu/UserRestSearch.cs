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
    public partial class UserResterauntSearch : Form
    {
        private int UserId = 0;

        public UserResterauntSearch(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //back
        {
            this.Hide();
            UserMainMenu UMM = new UserMainMenu(UserId);
            UMM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) //Menu
        {
            this.Hide();
            UserOrderMenu UOM = new UserOrderMenu(UserId);
            UOM.ShowDialog();
        }
    }
}
