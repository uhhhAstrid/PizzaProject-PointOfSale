using System;
using System.Collections.Generic; //Enables Lists
using System.Windows.Forms; //Built-in C# library for handling GUI
using Newtonsoft.Json; //enables JSON support
using System.Diagnostics; //enables Debug.Write/Debug.Writeline, and other things

namespace PizzaProject
{
    //todo (in Visual Studio) View > Task List; Ctrl + W also works. this makes all //todo show up
    internal static class EntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Menu m = new Menu();
            Menu.InitializeMenu();

            Manager testManager = new Manager("username", "password", "john", 0010);

            //Debug.WriteLine(testManager.Name);
            //Debug.WriteLine(testManager.UserID);
            //Debug.WriteLine(testManager.UserName);
            //Debug.WriteLine(testManager.Password);
            //Debug.WriteLine(testManager.ManagerOverrideCode);
            
            JSONHandler handler = new JSONHandler();
            handler.addCustomer(new Customer("huan", "307-314-2718", "hmai10@students.kennesaw.edu", "ga", "tucker", "30084", "marietta pkwy", "no"));
            handler.addCustomer(new Customer("will", "123-456-7890", "wswift1@students.kennesaw.edu", "credit", "yeff", "1234567890", 420));
            handler.writeToCustomers();



            handler.addOrder(new Order("cash", false, "307-314-2718"));
            // Order with an invalid phone number.
            Order credit = new Order("credit", true, "307-314-2718");


            OrderHandler.currentOrder = credit;
            OrderHandler.AddItemToOrder(new Item("2-Litre", "Pepsi"));
            OrderHandler.AddItemToOrder(new Item(new List<string>{ "Extra-Cheese","Pepperoni","Pineapple" },"Thiccc","18"));


            Order cash = new Order("cash", false, "123-456-7890");
            OrderHandler.currentOrder = cash;
            OrderHandler.AddItemToOrder(new Item("Small", "Lemonade"));
            OrderHandler.AddItemToOrder(new Item(new List<string> { "Mushrooms","Pineapple","Meatballs"},"Detroit-Style","12" ));


            handler.addOrder(credit);
            handler.addOrder(cash);


            handler.writeToOrders();


            handler.addUser(new Employee("huan", "password", "quan"));
            handler.addUser(new Manager("tcarreo1", "bruhmoment", "tenonch", 9018));
            handler.writeToUsers();


            //Once the following code is run, only events from the GUI will cause the code to progress forward; code after 'Application.Run' will not run until it is closed.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeScreen());
        }
    }
}
