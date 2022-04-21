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

        private void NewCustomerScreen_Load(object sender, EventArgs e)
        {


        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //if (first set of fields filled out): add customer to database
                //&if (second set of fields filled out): create new address, add to customer, add to database
                //&if (third set of fields, but not second, filled out): create new payment, add to customer, add to database
                //&if (all three sets of fields filled out): create new payment, create new address, add both to customer, add to database
            //if (any set of fields has only some fields filled out): create pop-up message; error: must fill in all 'payment information' or 'address' (or both) fields
            //if (first set of fields is missing any fields): create pop-up message; error: must fill in all 'customer information' fields
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //pop up menu: This will cancel creating the current customer and return you to the Home Page. continue? y/n
                //if (yes): homescreen.show, this.hide, popup.close
                //if (no): popup.hide
        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //depending on screen, may need to add logic for pop-up menu (this is copy and pasted)
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }
    }
}
