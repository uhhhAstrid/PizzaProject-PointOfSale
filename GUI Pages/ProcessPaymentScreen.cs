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
    public partial class ProcessPaymentScreen : Form
    {
        Order order;
        Customer customer;

        public ProcessPaymentScreen()
        {
            InitializeComponent();
        }

        public ProcessPaymentScreen(Order o, Customer c)
        {
            InitializeComponent();
            order = o;
            customer = c;
        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //warns user that this will cancel the current order
            var cancelOrderPopUp = new CancelOrder();
            cancelOrderPopUp.ShowDialog(this);
        }

        private void creditPayment_Click(object sender, EventArgs e)
        {
            //pulls up credit card info pop-up, which handles the logic
            var creditCardProcessPopUp = new CreditCardProcessingWindow(customer, order);
            creditCardProcessPopUp.ShowDialog(this);
        }

        private void SetBannerText(bool delivery, Order order, Customer customer)
        {
            if (delivery)
            {
                order.Delivery = delivery;
                receiptBanner.Text = "Delivery Order #" + order.OrderID + " for " + customer.Name;
            }
            else
            {
                receiptBanner.Text = "Carryout Order #" + order.OrderID + " for " + customer.Name;
            }

        }

        private void cashPayment_Click(object sender, EventArgs e)
        {
            //pop up: collect payment from customer; then advances to receipt screen
            var collectPaymentPopUp = new CashAndCheckProcessWindow();
            collectPaymentPopUp.ShowDialog(this);
        }

        private void checkPayment_Click(object sender, EventArgs e)
        {
            //pop up: collect payment from customer (there we go)
            var collectPaymentPopUp = new CashAndCheckProcessWindow();
            collectPaymentPopUp.ShowDialog(this);
        }

        private void ProcessPaymentScreen_Load(object sender, EventArgs e)
        {
            amountDue.Text = order.Total.ToString();
            totalField.Text = order.Total.ToString();
            subtotalField.Text = order.SubTotal.ToString();
            taxField.Text = order.Tax.ToString();
            foreach(Item i in order.Items)
            {
                var entry = new ListViewItem(new string[] { i.ItemType, i.Price.ToString(), i.toppingsToString(i.Toppings), i.Size, i.CrustType, i.Flavor });
                itemListView.Items.Add(entry);
            }
        }

        private void ProcessPaymentScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONHandler j = new JSONHandler();
            j.serializeCustomerList();
            j.serializeOrderList();
            j.serializeUserList();
        }
    }
}
