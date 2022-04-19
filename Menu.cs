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
            toppings.Add("Extra Cheese");
            toppings.Add("Pepperoni");
            toppings.Add("Mushrooms");
            toppings.Add("Onions");
            toppings.Add("Sausage");
            toppings.Add("Bacon");
            toppings.Add("Black Olives");
            toppings.Add("Green Peppers");
            toppings.Add("Pineapple");
            toppings.Add("Spinach");
            toppings.Add("Jalapenos");
            toppings.Add("Ham");

            crustType.Add("Hand Tossed");
            crustType.Add("Deep Dish");
            crustType.Add("Thin Crust");

            pizzaSize.Add("12\"");
            pizzaSize.Add("16\"");
            pizzaSize.Add("18\"");

            beverageFlavors.Add("Coke");
            beverageFlavors.Add("Sprite");
            beverageFlavors.Add("Dr. Pepper");
            beverageFlavors.Add("Lemonade");
            beverageFlavors.Add("Root Beer");
            beverageFlavors.Add("Water");

            beverageSize.Add("Small");
            beverageSize.Add("Medium");
            beverageSize.Add("Large");
            beverageSize.Add("2-Liter");
        }
    }
}