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
            //depending on screen, may need to add logic for pop-up menu (this is copy and pasted)
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
        }
    }
}
