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
            var customerFoundPopUp = new CustomerFoundConfirmation();
            customerFoundPopUp.ShowDialog();
        }

        //implementing this method is mandatory though
        private void phoneSearch_Click(object sender, EventArgs e)
        {
            //search order.json using "phone#" as the parameter
            //call json handler, call ordersbyphone#, return a list
            //then call a method to add those orders to the gui
            //temporary customer found popup
            var customerFoundPopUp = new CustomerFoundConfirmation();
            customerFoundPopUp.ShowDialog();
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
