using System.Collections.Generic;
using System;

namespace PizzaProject {
    //todo add constructor
    public class Order {
        
        //fields
        private int orderID { get; set; }
        private static int nextOrderID { get; set; }
        private string payType { get; set; }
        private bool delivery { get; set; }
        private DateTime date { get; set; }
        private decimal total { get; set; }
        private List<Item> items { get; set; }
        private decimal subTotal { get; set; }
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
            get { return subTotal; }
            set { subTotal = value; }
        }
        public string CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }

        //methods
        public void addItemToOrder(Item item)
        {
            items.Add(item);
        }
    }
}