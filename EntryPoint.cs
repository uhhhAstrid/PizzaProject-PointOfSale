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

            //Manager testManager = new Manager("username", "password", "john", 0010);

            //Debug.WriteLine(testManager.Name);
            //Debug.WriteLine(testManager.UserID);
            //Debug.WriteLine(testManager.UserName);
            //Debug.WriteLine(testManager.Password);
            //Debug.WriteLine(testManager.ManagerOverrideCode);
            
            JSONHandler handler = new JSONHandler();
            handler.addCustomerToList(new Customer("huan", "3073142718", "hmai10@students.kennesaw.edu", "ga", "tucker", "30084", "marietta pkwy", "no"));
            handler.addCustomerToList(new Customer("will", "1234567890", "wswift1@students.kennesaw.edu", "credit", "yeff", "1234567890", 420));
            handler.addCustomerToList(new Customer("will", "1234567891", "tayloswift@kennesaw.edu", "credit", "baylor swift", "1234567890", 421));
            handler.addCustomerToList(new Customer("well", "9324567891", "carlosswift@kennesaw.edu", "credit", "baylor swift", "1234567890", 422));
            handler.addCustomerToList(new Customer("swill", "7214567891", "alejandroswift@kennesaw.edu", "credit", "baylor swift", "1234567890", 423));
            
            handler.serializeCustomerList();



            handler.addOrderToList(new Order("cash", false, "307-314-2718"));
            // Order with an invalid phone number.
            Order credit = new Order("credit", true, "307-314-2718");


            OrderHandler.currentOrder = credit;
            OrderHandler.AddItemToOrder(new Item("2-Litre", "Pepsi"));
            OrderHandler.AddItemToOrder(new Item(new List<string>{ "Extra-Cheese","Pepperoni","Pineapple" },"Thiccc","18"));


            Order cash = new Order("cash", false, "123-456-7890");
            OrderHandler.currentOrder = cash;
            OrderHandler.AddItemToOrder(new Item("Small", "Lemonade"));
            OrderHandler.AddItemToOrder(new Item(new List<string> { "Mushrooms","Pineapple","Meatballs"},"Detroit-Style","12" ));


            handler.addOrderToList(credit);
            handler.addOrderToList(cash);


            handler.serializeOrderList();


            handler.addUserToList(new Employee("huan", "password", "quan"));
            handler.addUserToList(new Manager("tcarreo1", "bruhmoment", "tenonch", 9018));
            handler.serializeUserList();


            handler.deserializeCustomerList();
            
            //Once the following code is run, only events from the GUI will cause the code to progress forward;
            //because "EntryPoint" is single threaded
            //code after 'Application.Run' will not run until it is closed.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeScreen());
        }
    }
}
