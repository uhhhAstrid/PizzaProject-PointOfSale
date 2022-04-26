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
    public partial class MakeOrderScreen : Form
    {

        Customer customer;
        bool delivery;
        Order order;

        public MakeOrderScreen()
        {
            InitializeComponent();
        }

        public MakeOrderScreen(Customer c)
        {
            InitializeComponent();
            customer = c;
            order = new Order("", false, c.PhoneNumber);
            SetBannerText(false, order, c);
        }

        public MakeOrderScreen(bool delivery, Customer c)
        {
            InitializeComponent();
            this.delivery = delivery;
            customer = c;
            order = new Order("", delivery, c.PhoneNumber);
            SetBannerText(delivery, order, c);
        }

        private void SetBannerText(bool delivery, Order order, Customer customer)
        {
            if (delivery)
            {
                orderInfo.Text = "Delivery Order #" + order.OrderID + " for " + customer.Name; 
            }
            else
            {
                orderInfo.Text = "Carryout Order #" + order.OrderID + " for " + customer.Name;
            }
          
        }

        private void addPizza_Click(object sender, EventArgs e)
        {
            //open 'add pizza' menu
            var toppings = new List<string>(0);
            Item i = new Item(toppings, "", "");
            var addPizzaPopUp = new AddPizzaWindow(i, this);
            addPizzaPopUp.ShowDialog(this);
        }

        private void addDrink_Click(object sender, EventArgs e)
        {
            //open 'add drink' menu
            Item i = new Item("", "");
            var addDrinkPopUp = new AddDrinkWindow(i, this);
            addDrinkPopUp.ShowDialog(this);
        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //confirmation of return to home
            var cancelOrderPopUp = new CancelOrder();
            cancelOrderPopUp.ShowDialog(this);
        }

        private void proceedToPayment_Click(object sender, EventArgs e)
        { 
            //confirm finalization; popup handles logic
            var finalizeOrderPopUp = new FinalizeOrder(order, customer);
            finalizeOrderPopUp.ShowDialog(this);
            
        }

        private void cancelOrder_Click(object sender, EventArgs e)
        {
            //confirm cancellation; popup handles logic
            var cancelOrderPopUp = new CancelOrder();
            cancelOrderPopUp.ShowDialog(this);
        }

        private void MakeOrderScreen_Load(object sender, EventArgs e)
        {
            subtotalField.Text = "$0.00";
            taxField.Text = "$0.00";
            totalField.Text = "$0.00";
        }

        //credit to jeff for his code implementing list view technology
        public void AddItemToListView(Item i)
        {
            var entry = new ListViewItem(new string[] {i.ItemType, i.Price.ToString(), i.toppingsToString(i.Toppings), i.Size, i.CrustType, i.Flavor});
            itemListView.Items.Add(entry);
        }

        private void CalculateAndUpdate(Order o)
        {
            PaymentHandler p = new PaymentHandler();
            var subtotal = p.CalculateSubtotalOfOrder(o);
            var tax = p.CalculateTax(subtotal);
            var total = p.CalculateOrderTotal(o);

            order.Total = total;
            order.SubTotal = subtotal;
            order.Tax = tax;

            subtotalField.Text = subtotal.ToString("0.##");
            taxField.Text = tax.ToString("0.##");
            totalField.Text = total.ToString("0.##");
        }

        public void GetDataFromPopup(Item i)
        {
            PaymentHandler p = new PaymentHandler();
            i.Price = p.CalculatePriceOfItem(i);
            AddItemToListView(i);
            order.Items.Add(i);
            CalculateAndUpdate(order);
        }

        private void MakeOrderScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONHandler j = new JSONHandler();
            j.serializeCustomerList();
            j.serializeOrderList();
            j.serializeUserList();
        }
    }
}
