using System;
using System.Windows.Forms;

namespace cs4227.UI
{
    public partial class SysViewRestaraunt : Form
    {
        private readonly int AdminId;
        private readonly int RestaurantId;

        public SysViewRestaraunt(int AdminId, int RestaurantId)
        {
            this.AdminId = AdminId;
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var SVO = new SysViewOrder(AdminId, RestaurantId);
            SVO.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var SVM = new SysViewMenu(AdminId, RestaurantId);
            SVM.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Rest = StaticAccessor.DB.GetRestaurant(RestaurantId);
            RestaurantNameLabel.Text = @"Restaurant: " + Rest.Name;
        }

        private void EditRestaurantButton_Click(object sender, EventArgs e)
        {
            Hide();
            var ERM = new EditRestaurantMenu(AdminId, RestaurantId, false, true);
            ERM.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            var SRM = new SysAdminRestaurantsMenu(AdminId);
            SRM.ShowDialog();
        }
    }
}