using System.Collections.Generic;
using System;

namespace PizzaProject {
    public class Order {
        private int orderID { get; }
        private string payType { get; }
        private bool delivery { get; }
        private DateTime date { get; }
        private decimal total { get; }
        private List<PizzaProject.Item> items { get; }
        private decimal subTotal { get; }

        public string customerPhone { get; set; }
    }
}