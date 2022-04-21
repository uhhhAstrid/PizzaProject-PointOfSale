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
    public partial class MakeOrderScreen : Form
    {
        public MakeOrderScreen()
        {
            InitializeComponent();
        }

        private void addPizza_Click(object sender, EventArgs e)
        {
            //open 'add pizza' menu
        }

        private void addDrink_Click(object sender, EventArgs e)
        {
            //open 'add drink' menu
        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //depending on screen, may need to add logic for pop-up menu (this is copy and pasted)
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void proceedToPayment_Click(object sender, EventArgs e)
        {
            //take relevant order data and pass to payment screen, load payment screen 
            var paymentScreen = new ProcessPaymentScreen();
            paymentScreen.Show();
            this.Hide();
        }

        private void cancelOrder_Click(object sender, EventArgs e)
        {
            //popup: y/n
            //y: home
            //n: stay
        }
    }
}
