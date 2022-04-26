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
    public partial class CreditCardProcessingWindow : Form
    {
        bool creditCardOrder;
        Customer customer;
        Order order;
        public CreditCardProcessingWindow()
        {
            InitializeComponent();
            creditCardOrder = true;
        }

        public CreditCardProcessingWindow(Customer c, Order o)
        {
            InitializeComponent();
            customer = c;
            order = o;
            creditCardOrder = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var receiptScreen = new ReceiptScreen(creditCardOrder, customer, order);
            receiptScreen.Show();
            Owner.Close();
            this.Close();
        }

        private void CreditCardProcessingWindow_Load(object sender, EventArgs e)
        {
            amountDue.Text = order.Total.ToString();
        }
    }
}
