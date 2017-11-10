﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs4227.UI
{
    public partial class SysAdminMenu : Form
    {
        Timer t = new Timer();
        private int UserId = 0;

        public SysAdminMenu(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private void SysAdminMenu_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.UpdateTime_Tick);

            t.Start();
        }

        private void UpdateTime_Tick(object sender, EventArgs e)
        {
            String date = DateTime.Now.ToString("dd/MM/yyyy");
            String time = DateTime.Now.ToString("h:mm:ss tt");
            DisplayDateLabel.Text = @"Date: " + date;
            DisplayTimeLabel.Text = @"Current Time: " + time;
        }

        private void RestaurantsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysAdminRestaurantsMenu SRM = new SysAdminRestaurantsMenu(UserId);
            SRM.ShowDialog();
        }

        private void AdminsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SysAdminAdminsMenu SAAM = new SysAdminAdminsMenu(UserId);
            SAAM.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginMenuV2();
        } 
    }
}
