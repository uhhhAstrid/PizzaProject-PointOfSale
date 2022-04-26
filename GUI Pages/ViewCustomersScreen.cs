using PizzaProject.GUI_Pages.PopUp_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject.GUI_Pages
{
    public partial class ViewCustomersScreen : Form
    {
        public ViewCustomersScreen()
        {
            InitializeComponent();
        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //returns user to home
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string s = phoneSearchField.Text;
            JSONHandler j = new JSONHandler();
            Customer c = j.retrieveCustomer(s);

            if (c != null)
            {
                var customerFoundPopUp = new CustomerFoundConfirmationCR(c);
                customerFoundPopUp.Show(this);
                PopulateInfoFields(c);
            }
            else
            {
                var customerNotFound = new CustomerNotFound();
                customerNotFound.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var managerOverridePopUp = new ManagerOverrideRequest(this);
            managerOverridePopUp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //temporary popup to request manager override
            var managerOverridePopUp = new ManagerOverrideRequest();
            managerOverridePopUp.ShowDialog();
        }

        public void managerOverrideValidated()
        {
            creditInfo.Visible = true;
        }

        private void ViewCustomersScreen_Load(object sender, EventArgs e)
        {
            creditInfo.Visible = false;
        }

        private void PopulateInfoFields(Customer c)
        {
            nameField.Text = c.Name;
            phoneField.Text = c.PhoneNumber;
            emailField.Text = c.Email;
            if (c.Payment.CardNumber.Length >= 1)
            {
                cardNumberField.Text = c.Payment.CardNumber;
                nameOnCardField.Text = c.Payment.NameOnCard;
                cvvField.Text = c.Payment.CVV.ToString();
                cardTypeField.Text = c.Payment.CardType;
            }
            if(c.Address.Street.Length >= 1)
            {
                streetField.Text = c.Address.Street;
                stateField.Text = c.Address.State;
                cityField.Text = c.Address.City;
                zipField.Text = c.Address.Zip;
                additionalField.Text = c.Address.AdditionalAddressInfo;
            }
        }

        private void confirmEdits_Click(object sender, EventArgs e)
        {
            string s = phoneSearchField.Text;
            JSONHandler j = new JSONHandler();
            Customer c = j.retrieveCustomer(s);

            c.Name = nameField.Text;
            c.PhoneNumber = phoneField.Text;
            c.Email = emailField.Text;
            if (cardNumberField.Text.Length >= 1)
            {
                c.Payment.CardNumber = cardNumberField.Text;
                c.Payment.NameOnCard = nameOnCardField.Text;
                c.Payment.CVV = Int32.Parse(cvvField.Text);
                c.Payment.CardType = cardTypeField.Text;
            }
            if (streetField.Text.Length >= 1)
            {
                c.Address.Street = streetField.Text;
                c.Address.State = stateField.Text;
                c.Address.City = cityField.Text;
                c.Address.Zip = zipField.Text;
                c.Address.AdditionalAddressInfo = additionalField.Text;
            }

            j.updateCustomer(c, phoneSearchField.Text);
            PopulateInfoFields(c);
            var infoUpdated = new CustomerUpdated();
            infoUpdated.Show();
        }

        private void ViewCustomersScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONHandler j = new JSONHandler();
            j.serializeCustomerList();
            j.serializeOrderList();
            j.serializeUserList();
        }
    }
}
