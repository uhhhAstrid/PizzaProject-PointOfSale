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
    public partial class CashAndCheckProcessWindow : Form
    {
        Order order;
        Customer customer;
        public CashAndCheckProcessWindow()
        {
            InitializeComponent();
        }

        public CashAndCheckProcessWindow(Customer c, Order o)
        {
            customer = c;
            order = o;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var receiptScreen = new ReceiptScreen(false, customer, order);
            receiptScreen.Show();
            Owner.Hide();
            this.Close();
        }

        private void CashAndCheckProcessWindow_Load(object sender, EventArgs e)
        {
            orderTotal.Text = order.Total.ToString("0.##");
        }
    }
}
