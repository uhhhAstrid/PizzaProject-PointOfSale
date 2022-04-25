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
        //fields
        Customer customer;
        bool delivery;

        //constructors
        public StartOrderScreen()
        {
            InitializeComponent();
        }

        public StartOrderScreen(Customer c)
        {
            InitializeComponent();
            customer = c;
        }
        //methods

        private void StartOrderScreen_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //confirms order cancellation
            var cancelOrderPopup = new CancelOrder();
            cancelOrderPopup.ShowDialog(this);
        }

        private void cancelOrder_Click(object sender, EventArgs e)
        {
            var cancelOrderPopup = new CancelOrder();
            cancelOrderPopup.ShowDialog(this);
        }

        //this is really convoluted 3am code (do not read; I will fix before release -astrid)
        //todo: fix before release
        private void deliveryOrder_Click(object sender, EventArgs e)
        {

            //first, check fields for information and create a customer if it is all present
            bool customerInfo = false, addressInfo = false;

            if (customer != null || (nameField.Text.Length > 0 && phoneField.Text.Length > 0 && emailField.Text.Length > 0))
            {
                customerInfo = true;
            }
            if ((customer != null && customer.Address.Street != null ) || (stateField.Text.Length > 0 && cityField.Text.Length > 0 && zipField.Text.Length > 0 && streetField.Text.Length > 0 && addressField.Text.Length > 0))
            {
                addressInfo = true;
            }

            //only creates new customer if one does not exist
            if (customerInfo && addressInfo && customer == null)
            {
                customer = new Customer(nameField.Text, phoneField.Text, emailField.Text, stateField.Text, cityField.Text, zipField.Text, streetField.Text, addressField.Text);
            }
            //since delivery cannot happen without address info; does not create a customer if address info is invalid.


            //checks customer for info, throws error if it is not available.
                if (customer != null && (addressInfo = false || customer.Address == null))
                {
                    var invalidAddressPopUp = new DeliverAddressIncomplete();
                    invalidAddressPopUp.ShowDialog();
                }
                else if (customerInfo = false || customer == null)
                {
                    if (addressInfo = false)
                    {
                    var invalidAddressPopUp = new DeliverAddressIncomplete();
                    invalidAddressPopUp.ShowDialog();
                    }
                    else
                    {
                    var invalidCustomerInfoPopUp = new CustomerInfoIncomplete();
                    invalidCustomerInfoPopUp.ShowDialog();
                    }
                }
            
            if (customer != null && customer.PhoneNumber != null && customer.Address != null)
            {
                delivery = true;
                var makeOrder = new MakeOrderScreen(delivery, customer);
                makeOrder.Show();
                this.Hide();
            }
        }

        private void pickupOrder_Click(object sender, EventArgs e)
        {
            if (customer == null)
            {
                var invalidCustomerInfoPopUp = new CustomerInfoIncomplete();
                invalidCustomerInfoPopUp.ShowDialog();
            }
            else
            {
                var makeOrder = new MakeOrderScreen(customer);
                makeOrder.Show();
                this.Hide();
            }
        }

       
    }
}
