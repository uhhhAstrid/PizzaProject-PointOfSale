using PizzaProject.GUI_Pages;
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

namespace PizzaProject
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void anchovy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            var changeUserScreen = new ChangeUserScreen();
            changeUserScreen.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //User clicks "New Order" Button, opening "Start Order Screen"
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            var startOrderScreen = new StartOrderScreen();
            startOrderScreen.Show();
            this.Hide();
        }

        //Search Customer Database for Customers matching the phone number in the search field
        private void searchCustomers_Click(object sender, EventArgs e)
        {
            //the content of "customerLookup" is pulled and then the customer list is searched for a matching customer
            string s = customerLookup.Text;
            JSONHandler j = new JSONHandler();
            Customer c = j.retrieveCustomer(s);
            if(c != null)
            {
                var customerFoundHome = new CustomerFoundHome(c);
                customerFoundHome.Show(this);
            }
            else
            {
                var customerNotFoundPopUp = new CustomerNotFound();
                customerNotFoundPopUp.ShowDialog();
            }
        }

        private void viewCustomersButton_Click(object sender, EventArgs e)
        {
            var viewCustScreen = new ViewCustomersScreen();
            viewCustScreen.Show();
            this.Hide();
        }

        private void viewOrdersButton_Click(object sender, EventArgs e)
        {
            var viewOrdersScreen = new ViewOrdersScreen();
            viewOrdersScreen.Show();
            this.Hide();
        }

        private void newCustomerButton_Click(object sender, EventArgs e)
        {
            var newCustomerScreen = new NewCustomerScreen();
            newCustomerScreen.Show();
            this.Hide();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void HomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONHandler j = new JSONHandler();
            j.serializeCustomerList();
            j.serializeOrderList();
            j.serializeUserList();
            Application.Exit();
        }
    }
}
