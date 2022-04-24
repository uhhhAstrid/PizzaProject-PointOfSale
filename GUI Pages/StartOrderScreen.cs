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
    public partial class StartOrderScreen : Form
    {
        public StartOrderScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartOrderScreen_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //depending on screen, may need to add logic for pop-up menu (this is copy and pasted)
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void cancelOrder_Click(object sender, EventArgs e)
        {
            //pop up menu, y/n
            //y: home
            //n: stay
        }

        private void deliveryOrder_Click(object sender, EventArgs e)
        {
            var makeOrder = new MakeOrderScreen();
            makeOrder.Show();
            this.Hide();
            //temporary popup for in address error
            var invalidAddressPopUp = new DeliverAddressIncomplete();
            invalidAddressPopUp.ShowDialog();
            // temporary popup for customer information error
            var invalidCustomerInfoPopUp = new CustomerInfoIncomplete();
            invalidCustomerInfoPopUp.ShowDialog();
            //todo: add logic to carry over that this order is type 'delivery', add customer phone # to the order.
            //also: add logic to prevent proceeding unless the 'delivery' fields are filled out
        }

        private void pickupOrder_Click(object sender, EventArgs e)
        {
            var makeOrder = new MakeOrderScreen();
            makeOrder.Show();
            this.Hide();
            // temporary popup for customer information error
            var invalidCustomerInfoPopUp = new CustomerInfoIncomplete();
            invalidCustomerInfoPopUp.ShowDialog();
            //todo: add logic to carry over that this order is type 'pickup', add customer phone # to the order.
        }
    }
}
