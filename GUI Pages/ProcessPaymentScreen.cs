using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject.GUI_Pages
{
    public partial class ProcessPaymentScreen : Form
    {
        public ProcessPaymentScreen()
        {
            InitializeComponent();
        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //depending on screen, may need to add logic for pop-up menu (this is copy and pasted)
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void creditPayment_Click(object sender, EventArgs e)
        {
            //todo: implement 
            //processpayment() call payment handler, etc
            //pull up credit card info if stored, otherwise a pop-up asks you to fill it in...
            //pop-up: payment collected y/n; if yes, proceed to final screen

            //temporary solution for testing purposes
            var receiptScreen = new ReceiptScreen();
            receiptScreen.Show();
            this.Hide();
        }

        private void cashPayment_Click(object sender, EventArgs e)
        {
            //pop up: complete payment physically (phrase this better lollll)
            //pop-up: payment collected y/n; if yes, proceed to final screen

            //temporary solution for testing purposes
            var receiptScreen = new ReceiptScreen();
            receiptScreen.Show();
            this.Hide();
        }

        private void checkPayment_Click(object sender, EventArgs e)
        {
            //pop up: collect payment from customer (there we go)
            //pop-up: payment collected y/n; if yes, proceed to final screen

            //temporary solution for testing purposes
            var receiptScreen = new ReceiptScreen();
            receiptScreen.Show();
            this.Hide();
        }
    }
}
