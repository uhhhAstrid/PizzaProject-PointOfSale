using System;
using System.Collections.Generic;

namespace PizzaProject
{
    public class Menu
    {
        //do not forget to add functionality for 'extra cheese', probably under 'toppings' 
        static List<string> toppings { get; set; }
        static List<string> crustType { get; set; }
        static List<string> pizzaSize { get; set; }
        static List<string> beverageFlavors { get; set; }
        static List<string> beverageSize { get; set; }

        //for this project, the above fields are hard-coded into the program; however, they could easily be read from a JSON file, text file, etc.
        public void InitializeMenu()
        {
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

            crustType = new List<string>
            {
                "Hand Tossed",
                "Deep Dish",
                "Thin Crust"
            };


            pizzaSize = new List<string>
            {
                "12\"",
                "16\"",
                "18\""
            };

            beverageFlavors = new List<string>
            {
                "Coke",
                "Sprite",
                "Dr. Pepper",
                "Lemonade",
                "Root Beer",
                "Water"
            };

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