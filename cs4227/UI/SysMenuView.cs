using System;
using System.Windows.Forms;

namespace cs4227.UI
{
    public partial class SysViewMenu : Form
    {
        private readonly int AdminId;
        private readonly int RestaurantId;

        public SysViewMenu(int AdminId, int RestaurantId)
        {
            this.AdminId = AdminId;
            this.RestaurantId = RestaurantId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var SVR = new SysViewRestaraunt(AdminId, RestaurantId);
            SVR.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var items = StaticAccessor.DB.GetFoodItems();
            foreach (var item in items)
                if (item.RestaurantId == RestaurantId)
                {
                    var row = new ListViewItem("" + item.Id);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row,
                        "" + StaticAccessor.DB.GetFoodItem(item.Id).Name));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row,
                        "" + StaticAccessor.DoubleToMoneyString(item.Cost)));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + (item.Deleted ? "Yes" : "No")));
                    listView.Items.Add(row);
                }
        }
    }
}