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
            //search customers.json for customers with phone# matching the one in the textbox: phoneField
            //temporary popup for if customer is found
            var customerFoundPopUp = new CustomerFoundConfirmationCR();
            customerFoundPopUp.ShowDialog();
            // temporary popup for if customer is not found
            var customerNotFoundPopUp = new CustomerNotFound();
            customerNotFoundPopUp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //temporary popup to request manager override
            var managerOverridePopUp = new ManagerOverrideRequest();
            managerOverridePopUp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //temporary popup to request manager override
            var managerOverridePopUp = new ManagerOverrideRequest();
            managerOverridePopUp.ShowDialog();
        }
    }
}
