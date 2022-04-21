using System.Collections.Generic;

namespace PizzaProject
{
    //todo: item add constructor
    /// <summary>
    /// Stores item data for a single item instance.
    /// </summary>
    public class Item
    {
            //fields
        private string itemType { get; set; }
        private List<string> toppings { get; set; }
        private string crustType { get; set; }
        private string size { get; set; }
        private string flavor { get; set; }
        
            //properties (read only, call methods to write)
        public string ItemType
        {
            get { return itemType; }
        }
        public List<string> Toppings 
        {
            get { return toppings; }
        }
        public string CrustType
        {
            get { return crustType; }
        }
        public string Size 
        {
            get { return size; }
        }
        public string Flavor
        {
            get { return flavor; }
        }
          
            //constructors
        //blank constructor; order initializes with an empty List<Item>.
        public Item()
        {

        }

        //new pizza item; use logic to call the correct item constructor based on itemtype.
        public Item(List<string> toppings, string crust, string size)
        {
            this.toppings = toppings;
            this.crustType = crust;
            this.size = size;
        }

        //new soda item
        public Item(string size, string flavor)
        {
            this.size = size;
            this.flavor = flavor;
        }
            //methods
        //set values of various item fields; not sure how this is different from setting in properties but it feels right. 
        public void AddToppingToItem(string topping)
        {
            toppings.Add(topping);
        }
        public void setItemType(string type)
        {
            itemType = type;
        }
        public void setCrustType(string crustType)
        {
            this.crustType = crustType;
        }
        public void setSize(string size)
        {
            this.size = size;
        }
        public void setFlavor(string flavor)
        {
            this.flavor = flavor;
        }
    }
}