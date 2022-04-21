using System.Collections.Generic;

namespace PizzaProject
{
    public class Menu
    {
        public static List<string> toppings { get; set; }
        public static List<string> crustType { get; set; }
        public static List<string> pizzaSize { get; set; }
        public static List<string> beverageFlavors { get; set; }
        public static List<string> beverageSize { get; set; }

        //for this project, the above fields are hard-coded into the program; however, they could easily be read from a JSON file, text file, etc.
        //these are loaded into the GUI at runtime; so the menu could be theoretically edited without having to change any GUI elements.
        public static void InitializeMenu()
        {
            //creates a list of the menu's current available toppings
            toppings = new List<string>
            {
                "Extra Cheese",
                "Pepperoni",
                "Mushrooms",
                "Onions",
                "Sausage",
                "Bacon",
                "Black Olives",
                "Green Peppers",
                "Pineapple",
                "Spinach",
                "Jalapenos",
                "Ham"
            };

            //creates a list of the menu's current available crusts
            crustType = new List<string>
            {
                "Hand Tossed",
                "Deep Dish",
                "Thin Crust"
            };

            //creates a list of the menu's current available pizza sizes
            pizzaSize = new List<string>
            {
                "12\"",
                "16\"",
                "18\""
            };

            //creates a list of the menu's current available beverage flavors
            beverageFlavors = new List<string>
            {
                "Coke",
                "Sprite",
                "Dr. Pepper",
                "Lemonade",
                "Root Beer",
                "Water"
            };

            //creates a list of the menu's current available beverage sizes
            beverageSize = new List<string>
            {
                "Small",
                "Medium",
                "Large",
                "2-Liter"
            };
        }
    }
}