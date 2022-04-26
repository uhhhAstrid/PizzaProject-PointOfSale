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
    public partial class FinalizeOrder : Form
    {
        Order order;
        Customer customer;

        public FinalizeOrder()
        {
            InitializeComponent();
        }

        public FinalizeOrder(Order o, Customer c)
        {
            InitializeComponent();
            order = o;
            customer = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var paymentScreen = new ProcessPaymentScreen(order, customer);
            paymentScreen.Show();
            Owner.Hide();
            this.Hide();
            
        }

    }
}
