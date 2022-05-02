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
    public partial class ViewOrdersScreen : Form
    {
        public ViewOrdersScreen()
        {
            InitializeComponent();
        }
        
        //searches for customer orders given phone #
        private void phoneSearch_Click(object sender, EventArgs e)
        {     
            //the content of "customerLookup" is pulled and then the customer list is searched for a matching customer
            //then, orders are searched using the customers phone #
            string s = phoneField.Text;
            JSONHandler j = new JSONHandler();
            Customer c = j.retrieveCustomer(s);
            List<Order> orders = null;
            if (c != null) {  orders = j.retrieveOrdersByPhoneNumber(c); }
            
            
            if (c != null && orders != null)
            {
                var customerFoundPopUp = new OrderSearchComplete(orders.Count);
                customerFoundPopUp.Show();
                foreach(Order o in orders)
                {
                    AddOrderToListView(o, c);
                }
            }
            else if (c != null)
            {
                var orderSearchComplete = new OrderSearchComplete();
                orderSearchComplete.Show();
            }
            else
            {
                var customerNotFound = new CustomerNotFound();
                customerNotFound.ShowDialog();
            }
        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //returns user to home
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        //credit to jeff for his code implementing list view technology
        public void AddOrderToListView(Order order, Customer customer)
        {
            var entry = new ListViewItem(new string[] {order.OrderID.ToString(), customer.Name, order.Date.ToShortDateString(), order.Total.ToString(),
            order.PayType, order.Delivery.ToString()});
            orderListView.Items.Add(entry);
        }

        private void ViewOrdersScreen_Load(object sender, EventArgs e)
        {

        }
        private void ViewOrdersScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONHandler j = new JSONHandler();
            j.serializeCustomerList();
            j.serializeOrderList();
            j.serializeUserList();
            Application.Exit();
        }
    }
}
