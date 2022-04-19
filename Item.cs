using System.Collections.Generic;

namespace PizzaProject
{
    //todo: item add constructor
    public class Item
    {
        //fields
        private string itemType { get; set; }
        private List<string> toppings { get; set; }
        private string crustType { get; set; }
        private string size { get; set; }
        private string flavor { get; set; }
        
        //properties
        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }
        public List<string> Toppings 
        {
            get { return toppings; }
        }
        public string CrustType
        {
            get { return crustType; }
            set { crustType = value; }
        }
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        public string Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        //methods
        public void AddToppingToItem(string topping)
        {
            toppings.Add(topping);
        }

    }
}