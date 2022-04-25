﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject.GUI_Pages.PopUp_Pages
{
    public partial class CancelOrder : Form
    {
        public CancelOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //todo: add logic which deletes the order/items currently in memory (though, garbage collection may get rid of them automatically).

            //user clicks "yes" meaning "cancel order"
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            Owner.Hide();
            this.Close();
        }
    }
}
