using System.Collections.Generic;

namespace PizzaProject
{
    public class Item
    {
        private string itemType { get; }
        private List<string> toppings { get; }
        private string crustType { get; }
        private string size { get; }
        private string flavor { get; }
    }
}