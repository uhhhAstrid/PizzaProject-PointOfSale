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
    public partial class NewCustomerScreen : Form
    {
        public NewCustomerScreen()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        //this code could really be cleaned up; but it works for now.
        private void submitButton_Click(object sender, EventArgs e)
        {

            //based on the fields completed, create a new customer using the data, then tell the user a customer was created
            //and give the option to start a new order with the customer,
            //finally, add the customer to the database.

            bool customerInfo = false, addressInfo = false, paymentInfo = false;

            if(nameField.Text.Length >0 && phoneField.Text.Length > 0 && emailField.Text.Length > 0)
            {
                customerInfo = true;
            }
            if (stateField.Text.Length >0 && cityField.Text.Length > 0 && zipField.Text.Length > 0 && streetField.Text.Length>0 && addressField.Text.Length > 0)
            {
                addressInfo = true;
            }
            if (cardTypeField.Text.Length > 0 && nameOnCardField.Text.Length > 0 && cardNumberField.Text.Length > 0 && cvvField.Text.Length > 0)
            {
                paymentInfo = true;
            }

            JSONHandler j = new JSONHandler;

            //Checks each condition from greatest amount of data included to least data included; 
            //If no fields have enough data to create a customer, an error pop up is shown
            if (customerInfo && addressInfo && paymentInfo)
            {
                Customer c = new Customer(nameField.Text, phoneField.Text, emailField.Text, cardTypeField.Text, nameOnCardField.Text, cardNumberField.Text, Int32.Parse(cvvField.Text), stateField.Text, cityField.Text, zipField.Text, streetField.Text, addressField.Text);
                j.addCustomerToList(c);
                var customerAddedPopUp = new CustomerAddedConfirmation(c);
                customerAddedPopUp.ShowDialog(this);
            }
            else if (customerInfo && addressInfo)
            {
                Customer c = new Customer(nameField.Text, phoneField.Text, emailField.Text, stateField.Text, cityField.Text, zipField.Text, streetField.Text, addressField.Text);
                j.addCustomerToList(c);
                var customerAddedPopUp = new CustomerAddedConfirmation(c);
                customerAddedPopUp.ShowDialog(this);
            }
            else if(customerInfo && paymentInfo)
            {
                Customer c = new Customer(nameField.Text, phoneField.Text, emailField.Text, cardTypeField.Text, nameOnCardField.Text, cardNumberField.Text, Int32.Parse(cvvField.Text));
                j.addCustomerToList(c);
                var customerAddedPopUp = new CustomerAddedConfirmation(c);
                customerAddedPopUp.ShowDialog(this);
            }
            else if (customerInfo)
            {
                Customer c = new Customer(nameField.Text, phoneField.Text, emailField.Text);
                j.addCustomerToList(c);
                var customerAddedPopUp = new CustomerAddedConfirmation(c);
                customerAddedPopUp.ShowDialog(this);
            }
            else
            {
                var incompleteCustomerInfoPopUp = new CustomerInfoIncomplete();
                incompleteCustomerInfoPopUp.ShowDialog(this);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var cancelAddCustomerPopUp = new CancelAddCustomer();
            cancelAddCustomerPopUp.ShowDialog(this);
        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //sends user to the home screen
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void NewCustomerScreen_Load(object sender, EventArgs e)
        {

        }

        private void NewCustomerScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONHandler j = new JSONHandler();
            j.serializeCustomerList();
            j.serializeOrderList();
            j.serializeUserList();
        }
    }
}
