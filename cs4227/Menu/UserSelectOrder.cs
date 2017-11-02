﻿using System;
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
    public partial class UserOrderMenu : Form
    {
        private int UserId = 0;
        private int RestaurantId = 0;

        public UserOrderMenu(int UserId, int RestaurantId)
        {
            this.RestaurantId = RestaurantId;
            this.UserId = UserId;
            InitializeComponent();
        }

        private void UserOrderMenu_Load(object sender, EventArgs e)
        {
            List<FoodItem> FoodItems = DatabaseHandler.GetRestaurantFoodItems(RestaurantId);
            foreach (FoodItem Food in FoodItems)
            {
                ListViewItem row = new ListViewItem("" + Food.Name);
                string cost = Food.Cost.ToString();
                if (cost.Length == 1 || cost.Length == 2)
                {
                    cost += ".00";
                }
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + cost));
                row.SubItems.Add(new ListViewItem.ListViewSubItem(row, "" + Food.Id));
                RestaurantMenu.Items.Add(row);
            }
        }

        private void RestaurantMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RestaurantMenu.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = RestaurantMenu.SelectedItems[0];
                YourOrder.Items.Add((ListViewItem)selectedRow.Clone());
                selectedRow.Selected = false;
            }
        }

        private void YourOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YourOrder.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = YourOrder.SelectedItems[0];
                selectedRow.Remove();
            }
        }

        private void button1_Click(object sender, EventArgs e) //back
        {
            this.Hide();
            UserMainMenu UMM = new UserMainMenu(UserId);
            UMM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //checkout
        {
            this.Hide();
            UserCheckout UC = new UserCheckout(UserId, RestaurantId);
            UC.ShowDialog();
        }
    }
}
