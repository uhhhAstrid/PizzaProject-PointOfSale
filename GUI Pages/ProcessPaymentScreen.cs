using PizzaProject.GUI_Pages.PopUp_Pages;
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
            //warns user that this will cancel the current order
            var cancelOrderPopUp = new CancelOrder();
            cancelOrderPopUp.ShowDialog(this);
        }

        private void creditPayment_Click(object sender, EventArgs e)
        {
            //pulls up credit card info pop-up, which handles the logic
            var creditCardProcessPopUp = new CreditCardProcessingWindow();
            creditCardProcessPopUp.ShowDialog(this);
        }

        private void cashPayment_Click(object sender, EventArgs e)
        {
            //pop up: collect payment from customer; then advances to receipt screen
            var collectPaymentPopUp = new CashAndCheckProcessWindow();
            collectPaymentPopUp.ShowDialog(this);
        }

        private void checkPayment_Click(object sender, EventArgs e)
        {
            //pop up: collect payment from customer (there we go)
            var collectPaymentPopUp = new CashAndCheckProcessWindow();
            collectPaymentPopUp.ShowDialog(this);
        }
    }
}
