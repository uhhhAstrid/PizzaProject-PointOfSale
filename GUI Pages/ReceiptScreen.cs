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
    public partial class ReceiptScreen : Form
    {
        bool creditPayment;
        Customer customer;
        Order order;
        public ReceiptScreen()
        {
            InitializeComponent();
        }

        public ReceiptScreen(bool credit, Customer c, Order o)
        {
            InitializeComponent();
            creditPayment = credit;
            customer = c;
            order = o;
            JSONHandler j = new JSONHandler();
            j.addOrderToList(order);
        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //depending on screen, may need to add logic for pop-up menu (this is copy and pasted)
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void ReceiptScreen_Load(object sender, EventArgs e)
        {

            signatureField.Visible = false;

            if (creditPayment)
            {
                signatureField.Visible = true;
            }

            if (order.Delivery)
            {
                receiptBanner.Text = "Delivery Order #" + order.OrderID + " for " + customer.Name;
            }
            else
            { 
                receiptBanner.Text = "Carryout Order #" + order.OrderID + " for " + customer.Name;
            }

            total.Text = order.Total.ToString("0.##");
            subtotalField.Text = order.SubTotal.ToString("0.##");
            taxField.Text = order.Tax.ToString("0.##");
            foreach (Item i in order.Items)
            {
                var entry = new ListViewItem(new string[] { i.ItemType, i.Price.ToString(), i.toppingsToString(i.Toppings), i.Size, i.CrustType, i.Flavor });
                itemListView.Items.Add(entry);
            }
        }

        private void ReceiptScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONHandler j = new JSONHandler();
            j.serializeCustomerList();
            j.serializeOrderList();
            j.serializeUserList();
        }
    }
}
