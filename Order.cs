using System.Collections.Generic;
using System;

namespace PizzaProject {
    /// <summary>
    /// Creates new order instances and tracks relevant information
    /// </summary>
    public class Order {
        
            //fields
        private int orderID { get; set; }
        private static int nextOrderID { get; set; }
        private string payType { get; set; }
        
        //true = this is a delivery order
        //false = this is a pickup order
        private bool delivery { get; set; }
      
        private DateTime date { get; set; }
        private decimal total { get; set; }
        private List<Item> items { get; set; }
        private decimal subtotal { get; set; }
        private decimal tax { get; set; }
        private string customerPhone { get; set; }

            //properties
        public int OrderID 
        { 
            get { return orderID; } 
            set { orderID = nextOrderID++; } 
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

            //constructor
        public Order(string payType, bool delivery, string phone)
        {
            this.payType = payType;
            this.delivery = delivery;
            date = DateTime.Now;
            total = 0M;
            subtotal = 0M;
            tax = 0M;
            items = new List<Item>();
            customerPhone = phone;
        }
    }
}