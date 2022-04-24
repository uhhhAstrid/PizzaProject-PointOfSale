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
        private string itemType;
        private List<string> toppings;
        private string crustType;
        private string size;
        private string flavor;
        
            //properties (read only, call methods to write)
        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }
        public List<string> Toppings 
        {
            get { return toppings; }
            set { toppings = value; }
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