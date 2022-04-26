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
        bool customerInfo;
        bool addressInfo;

            //constructors
        public StartOrderScreen()
        {
            InitializeComponent();
            customerInfo = false;
        }

        public StartOrderScreen(Customer c)
        {
            InitializeComponent();
            customer = c;
            customerInfo = true;
        }
        
            //methods
        private void StartOrderScreen_Load(object sender, EventArgs e)
        {
            if (customer != null) 
            { 
                customerInfo = true;
                if(customer.Address.Street.Length >= 1 && customer.Address.Street != "N/A" && customer.Address.Street != "n/a")
                {
                    addressInfo = true;
                }
                else
                {
                    addressInfo = false;
                }
                PopulateInfoFields(customer);
            }
        }
       
        private void PopulateInfoFields(Customer c) 
        {
            nameField.Text = c.Name;
            emailField.Text = c.Email;
            phoneField.Text = c.PhoneNumber;

            if (addressInfo)
            {
                streetField.Text = c.Address.Street;
                cityField.Text = c.Address.City;
                stateField.Text = c.Address.State;
                zipField.Text = c.Address.Zip;
                addressField.Text = c.Address.AdditionalAddressInfo;
            }
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

        private void deliveryOrder_Click(object sender, EventArgs e)
        {
            if (customerInfo && addressInfo)
            {
                proceedToDeliveryOrder(customer);
            }
            else if(customerInfo)
            {
                addAddressToCustomer(customer);
                if (addressInfo)
                {
                    proceedToDeliveryOrder(customer);
                }    
            }
            else
            {
                var c = createCustomer(true);
                if (c != null && addressInfo)
                {
                    proceedToDeliveryOrder(c);
                }
            }
        }
        
        private void pickupOrder_Click(object sender, EventArgs e)
        {
            if (customerInfo)
            {
                proceedToPickupOrder(customer);
            }
            else
            {
                var c = createCustomer(false);
                if (c != null)
                {
                    proceedToPickupOrder(c);
                }
            }
        }

        private bool verifyCustomerFields()
        {
            if (nameField.TextLength > 0 && phoneField.TextLength > 0 && emailField.TextLength > 0)
            {
                customerInfo = true;
                return true;
            }
            else { customerInfo = false;  return false; }
        }

        private bool verifyAddressFields()
        {
            if (stateField.TextLength > 0 && cityField.TextLength > 0 && zipField.TextLength > 0 && streetField.TextLength > 0 && addressField.TextLength > 0)
            {
                addressInfo = true;
                return true;
            }
            else { addressInfo = false;  return false; }
        }

        private Customer createCustomer(bool delivery)
        {
            var c = new Customer();
            JSONHandler j = new JSONHandler();

            if (verifyCustomerFields())
            {
                c.Name = nameField.Text;
                c.PhoneNumber = phoneField.Text;
                c.Email = emailField.Text;   
            }
            else
            {
                var invalidCustomerInfo = new CustomerInfoIncomplete();
                invalidCustomerInfo.ShowDialog();
                return null;
            }
            
            if (delivery)
            {
                if (verifyAddressFields())
                {
                    c.Address.State = stateField.Text;
                    c.Address.City = cityField.Text;
                    c.Address.Zip = zipField.Text;
                    c.Address.Street = streetField.Text;
                    c.Address.AdditionalAddressInfo = addressField.Text;
                }
                else
                {
                    var invalidAddressPopup = new DeliverAddressIncomplete();
                    invalidAddressPopup.ShowDialog();
                    return null;
                }
            }
            j.addCustomerToList(c);
            return c;
        }
        
        private void addAddressToCustomer(Customer c)
        {
            if (verifyAddressFields())
            {
                c.Address.State = stateField.Text;
                c.Address.City = cityField.Text;
                c.Address.Zip = zipField.Text;
                c.Address.Street = streetField.Text;
                c.Address.AdditionalAddressInfo = addressField.Text;
            }
            else
            {
                addressInfo = false;
                var invalidAddressPopup = new DeliverAddressIncomplete();
                invalidAddressPopup.ShowDialog();
            }
        }

        private void proceedToDeliveryOrder(Customer c)
        {
            var makeOrder = new MakeOrderScreen(true, c);
            makeOrder.Show();
            this.Hide();
        }

        private void proceedToPickupOrder(Customer c)
        {
            var makeOrder = new MakeOrderScreen(false, c);
            makeOrder.Show();
            this.Hide();
        }

        private void StartOrderScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONHandler j = new JSONHandler();
            j.serializeCustomerList();
            j.serializeOrderList();
            j.serializeUserList();
        }
    }
}
