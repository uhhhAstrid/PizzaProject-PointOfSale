using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject.GUI_Pages.PopUp_Pages
{
    public partial class CustomerAddedConfirmation : Form
    {
        Customer customer;

        public CustomerAddedConfirmation()
        {
            InitializeComponent();
        }

        public CustomerAddedConfirmation(Customer c)
        {
            InitializeComponent();
            customer = c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //todo: start order with customer logic
            var startOrderWithCustomer = new StartOrderScreen(customer);
            startOrderWithCustomer.Show();
            this.Close();
            Owner.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Close();
            Owner.Hide();
        }
    }
}
