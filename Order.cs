using System.Collections.Generic;
using System;

namespace PizzaProject {
    /// <summary>
    /// Creates new order instances and tracks relevant information
    /// </summary>
    public class Order {
        
            //fields
        private int orderID;
        private static int nextOrderID { get; set; }
        private string payType;
        
        //true = this is a delivery order
        //false = this is a pickup order
        private bool delivery;
        private DateTime date;
        private decimal total;
        private List<Item> items;
        private decimal subtotal;
        private decimal tax;
        private string customerPhone;

            //properties
        public int OrderID 
        { 
            get { return orderID; } 
            set { orderID = nextOrderID; } 
        }
        public string PayType
        {
            get { return payType; }
            set { payType = value; }
        }
        public bool Delivery 
        {
            get { return delivery; } 
            set { delivery = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }
        public decimal SubTotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        public string CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }

        public decimal Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        public static void setNextOrderID(int newID)
        {
            nextOrderID = newID;
        }
        //constructor
        // reminder that this is a testing constructor
        public Order(string payType, bool delivery, string phone)
        {

            orderID = nextOrderID;
            nextOrderID++;
            this.payType = payType;
            this.delivery = delivery;
            date = DateTime.Now;
            total = 0M;
            subtotal = 0M;
            tax = 0M;
            items = new List<Item>();
            customerPhone = phone;
        }
        public Order()
        {

        }
    }
}