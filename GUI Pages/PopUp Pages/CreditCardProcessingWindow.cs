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
    public partial class CreditCardProcessingWindow : Form
    {
        public CreditCardProcessingWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //todo: call processpayment()
            var receiptScreen = new ReceiptScreen();
            receiptScreen.Show();
            Owner.Close();
            this.Close();
        }
    }
}
