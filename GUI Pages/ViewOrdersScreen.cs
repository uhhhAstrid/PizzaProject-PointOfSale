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
    public partial class ViewOrdersScreen : Form
    {
        public ViewOrdersScreen()
        {
            InitializeComponent();
        }

        //implementing this method is OPTIONAL and has NO EFFECT on our grade
        private void nameSearch_Click(object sender, EventArgs e)
        {
            //search order.json using "name" as the parameter
            //call json handler, call orders by name, return a list
            //then call a method to add those orders to the gui
            //temporary customer found popup
            var customerFoundPopUp = new OrderSearchComplete();
            customerFoundPopUp.ShowDialog();
        }

        //implementing this method is mandatory though
        private void phoneSearch_Click(object sender, EventArgs e)
        {     
            //the content of "customerLookup" is pulled and then the customer list is searched for a matching customer
            //then, orders are searched using the customers phone #

            string s = phoneField.Text;
            JSONHandler j = new JSONHandler();
            Customer c = j.retrieveCustomer(s);
            List<Order> orders = j.retrieveOrders(c);
            
            if (c != null)
            {
                var customerFoundPopUp = new OrderSearchComplete();
                customerFoundPopUp.ShowDialog(this);
            }
            else
            {
                var orderSearchComplete = new OrderSearchComplete();
                orderSearchComplete.ShowDialog(this);
            }
       
        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //returns user to home
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }
    }
}
