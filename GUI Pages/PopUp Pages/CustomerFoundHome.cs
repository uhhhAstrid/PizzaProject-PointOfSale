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
    public partial class CustomerFoundHome : Form
    {

        private Customer customer;

        public CustomerFoundHome()
        {
            InitializeComponent();
        }

        public CustomerFoundHome(Customer c)
        {
            InitializeComponent();
            customer = c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //todo: start order with customer (from home page search)
            var startNewOrder = new StartOrderScreen(customer);
            startNewOrder.Show();
            Owner.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
