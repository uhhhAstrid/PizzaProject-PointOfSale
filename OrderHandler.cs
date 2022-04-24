using System.Collections.Generic;

namespace PizzaProject {
    
    //todo: orderhandler logic
    public static class OrderHandler {

        //takes data from GUI events, and processes changes to the order accordingly.
        //retrieves data from order for GUI
        public static Order currentOrder { get; set; }

        public static void AddItemToOrder(Item item)
        {
            currentOrder.Items.Add(item); //todo: test this
        }
        public static decimal OrderTotal()
        {
            return currentOrder.Total;
        }
        public static decimal OrderSubTotal()
        {
            return currentOrder.SubTotal;
        }
        public static List<Item> ItemsInOrder()
        {
            return currentOrder.Items;
        }
    }
       
}