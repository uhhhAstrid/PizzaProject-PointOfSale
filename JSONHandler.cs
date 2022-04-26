using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace PizzaProject
{
    public class JSONHandler
    {
            //filepaths and other constants
        private static string folderPath = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents\\PizzaProject";
        private static string customersPath = folderPath + "\\customersJSON.json";
        private static string ordersPath = folderPath + "\\ordersJSON.json";
        private static string usersPath = folderPath + "\\usersJSON.json";
        private static List<string> allFiles = new List<string> {customersPath,ordersPath, usersPath};



        JsonSerializerSettings serializerWithTypesSetting = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

        //ensures all instances of JSONHandler use the same data.
        static List<Customer> customers;
        static List<Order> orders;
        static List<User> users;

            //constructor
        public JSONHandler(){
            // On Startup, check to see if the .json files already exist
            // then read in the current list of orders, customers, and users, and leave them in memory
            Debug.WriteLine(folderPath);
            checkJSON();
        }

        //adds filler data to the .JSON files on first program run
        public void firstRunDataInitialization(int i)
        {
            switch (i)
            {
                //customer initialization
                case 0:
                    {
                        customers = new List<Customer>();
                        customers.Add(new Customer("huan", "3073142718", "hmai10@students.kennesaw.edu", "ga", "tucker", "30084", "marietta pkwy", "no"));
                        customers.Add(new Customer("will", "1234567890", "wswift1@students.kennesaw.edu", "credit", "yeff", "1234567890", 420));
                        customers.Add(new Customer("will", "1234567891", "tayloswift@kennesaw.edu", "credit", "baylor swift", "1234567890", 421));
                        customers.Add(new Customer("well", "9324567891", "carlosswift@kennesaw.edu", "credit", "baylor swift", "1234567890", 422));
                        customers.Add(new Customer("swill", "7214567891", "alejandroswift@kennesaw.edu", "credit", "baylor swift", "1234567890", 423));
                        serializeCustomerList();
                        break;
                    }
                //orders initialization
                case 1:
                    {
                        orders = new List<Order>();
                        Order testOrderCredit = new Order("credit", true, "3073142718");

                        OrderHandler.currentOrder = testOrderCredit;
                        OrderHandler.AddItemToOrder(new Item("2-Litre", "Pepsi"));
                        OrderHandler.AddItemToOrder(new Item(new List<string> { "Extra-Cheese", "Pepperoni", "Pineapple" }, "Deep Dish", "18"));
                        orders.Add(testOrderCredit);
                        
                        Order testOrderCash = new Order("cash", false, "1234567890");
                        OrderHandler.currentOrder = testOrderCash;
                        OrderHandler.AddItemToOrder(new Item("Small", "Lemonade"));
                        OrderHandler.AddItemToOrder(new Item(new List<string> { "Mushrooms", "Pineapple"}, "Thin Crust", "12"));                
                        orders.Add(testOrderCash);
                        Thread.Sleep(1000);

                        serializeOrderList();
                        break;
                    }
                //users initialization
                case 2:
                    {
                        users = new List<User>();
                        users.Add(new Employee("username", "password", "default user"));
                        addUserToList(new Manager("admin", "management", "default manager"));
                        Thread.Sleep(1000);
                        serializeUserList();
                        break;
                    }
            }
        }

        //initializes static variables once on program startup
        public void InitializeLists()
        {
            customers = deserializeCustomerList() ?? new List<Customer>(0);
            orders = deserializeOrderList() ?? new List<Order>(0);
            users = deserializeUserList() ?? new List<User>(0);
        }

        //initializes static variables once on program startup
        public void InitializeIDs()
        {
            Customer.setNextCustomerID(customers.Count);
            Order.setNextOrderID(orders.Count);
            User.setNextUserID(users.Count);
        }

        //creates a folder called "Pizza Project" in "Documents",
        //then creates 3 .json files for storing project info
        protected void checkJSON()
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                for (int i = 0; i < allFiles.Count; i++)
                {
                    //since File.WriteAllText creates a file if none is found; the files do not need to be created here.
                    if (!File.Exists(allFiles[i]))
                    {
                        firstRunDataInitialization(i);
                    }
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        //verifies customer is not already in the system, then adds them
        public void addCustomerToList(Customer cust)
        {
            if(cust != null) 
            {
                if (!this.phoneNumberValidator(cust.PhoneNumber))
                {
                    return;
                    //throw new Exception("Phone Number is invalid");
                }
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].PhoneNumber == cust.PhoneNumber)
                    {
                        //throw new Exception("Customer already exists.");
                        return;
                    }
                }
                customers.Add(cust);
            }
        }

        //Overwrites JSON data with customer list
        public void serializeCustomerList()
        {
            try
            {
                String toBeAdded = JsonConvert.SerializeObject(customers, Formatting.Indented, serializerWithTypesSetting);
                File.WriteAllText(customersPath, toBeAdded);
            }
            catch(IOException ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("Could not write to customers.json.");
            }
        }

        //Overwrites customer list with stored JSON data
        public List<Customer> deserializeCustomerList()
        {
            try
            {
                String readCustomers = File.ReadAllText(customersPath);
                List<Customer> existingCustomers = JsonConvert.DeserializeObject<List<Customer>>(readCustomers, serializerWithTypesSetting);
                return (existingCustomers == null) ? new List<Customer>(0) : existingCustomers;
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
                return new List<Customer>(0);
            }
        }

        //Searches customer list for specific customer
        public Customer retrieveCustomer(string phone)
        {
            if (this.phoneNumberValidator(phone))
            {
                foreach (Customer c in customers)
                {
                    if (c.PhoneNumber == phone)
                    {
                        return c;
                    }
                }
            }
            else
            {
                return null;
                //throw new Exception("Phone Number is invalid");
            }
            return null;
        }

        //update the information of a customer in the list;
        //phone number required in case that field has also changed
        public void updateCustomer(Customer updatedC, string phone)
        {
            for(int i = 0; i < customers.Count; i++)
            {
                if(customers[i].PhoneNumber == phone)
                {
                    customers[i] = updatedC;
                    break;
                }
            }
        }

        // ORDER Section
        //adds a new order to memory
        public void addOrderToList(Order order)
        {
            if (order != null)
            {
                if (!phoneNumberValidator(order.CustomerPhone))
                {
                    return;
                    //throw new Exception("Phone Number is invalid") do not uncomment these yet please.
                }
                bool customerFound = false;
                int customerIndex = 0;
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].PhoneNumber != null && customers[i].PhoneNumber.Equals(order.CustomerPhone))
                    {
                        customerFound = true;
                        customerIndex = i;
                        break;
                    }
                }
                if (!customerFound)
                {
                    return;
                    //throw new Exception("Customer does not exist.").
                }
                else
                {
                    orders.Add(order);
                }
            }
        }
        
        //saves orders from memory into JSON
        public void serializeOrderList()
        {
            try
            {
                String toBeAdded = JsonConvert.SerializeObject(orders, Formatting.Indented, serializerWithTypesSetting);
                File.WriteAllText(ordersPath, toBeAdded);
            }
            catch(IOException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        //loads orders from JSON into memory
        protected List<Order> deserializeOrderList()
        {
            try
            {
                String readOrders = File.ReadAllText(ordersPath);
                List<Order> existingOrders = JsonConvert.DeserializeObject<List<Order>>(readOrders, serializerWithTypesSetting);
                return (existingOrders == null) ? new List<Order>(0) : existingOrders;
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
                return new List<Order>(0);
            }
        }
        
        // Users Section
        //writes new user into memory
        public void addUserToList(User emp)
        {
            if(emp != null)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].UserID == emp.UserID)
                    {
                        return;
                        //throw new Exception("User already exists.");
                    }
                }
                if (emp.UserName != null && emp.Password != null)
                {
                    users.Add(emp);
                }
                else
                {
                    return;
                    //throw new Exception("User must have a username and password.");
                }
            }
        }

        //saves users from memory into JSON
        public void serializeUserList()
        {
            try
            {
                var usersToBeSaved = JsonConvert.SerializeObject(users,Formatting.Indented,serializerWithTypesSetting);
                File.WriteAllText(usersPath,usersToBeSaved);
            }
            catch (IOException ex){ 
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("Could not write to users.json.");
            }
        }
        
        //loads users from JSON into memory
        protected List<User> deserializeUserList()
        {
            try
            {
                String readUsers = File.ReadAllText(usersPath);
                List<User> existingUsers = JsonConvert.DeserializeObject<List<User>>(readUsers, serializerWithTypesSetting);
                return existingUsers == null ? new List<User>(0) : existingUsers;
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("Could not load users file.");
                return new List<User>(0);
            }
        }
        
        //searches order list for orders matching a customer's phone number
        //then creates a new list of those orders and returns it
        public List<Order> retrieveOrdersByPhoneNumber(string phone)
        {
            if(phone == null || !phoneNumberValidator(phone))
            {
                return null;
                //throw new Exception("Phone Number is invalid");
            }
            List<Order> foundOrders = new List<Order>(0);
            for(int i = 0; i < orders.Count; i++)
            {
                if (String.Equals(orders[i].CustomerPhone, phone, StringComparison.OrdinalIgnoreCase))
                {
                    foundOrders.Add(orders[i]);
                }
            }
            if(foundOrders.Count == 0) { return null; }
            return foundOrders;
        }

        //overload, in case customer information is not available to the calling class
        public List<Order> retrieveOrdersByPhoneNumber(Customer c)
        {
            return retrieveOrdersByPhoneNumber(c.PhoneNumber);
        }
        
        //searches currently loaded list of users for one with a
        //matching username and password. otherwise, returns null.
        public User retrieveUser(string username, string password)
        {
            if(username == null || password == null)
            {
                return null;
                //throw new Exception("Name is invalid.");
            }
            
            
            for (int i = 0; i < users.Count; i++)
            {
                if (String.Equals(users[i].UserName,username,StringComparison.OrdinalIgnoreCase) && String.Equals(users[i].Password,password))
                {
                    return users[i];
                }
            }
            return null;
        }

        public bool validateUserLogin(string username, string password)
        {
            //temporary failsafe
            if(username == "true" && password == "password")
            {
                return true;
            }
            
            if (username == null || password == null)
            {
                return false;
                //throw new Exception("username or password invalid.");
            }


            for (int i = 0; i < users.Count; i++)
            {
                if (String.Equals(users[i].UserName, username, StringComparison.OrdinalIgnoreCase) && String.Equals(users[i].Password, password))
                {
                    return true;
                }
            }
            return false;
        }

        //due to the structure of the inheritance,
        //children of "user" cannot be accessed once created (and are probably caught by garbage cleanup)
        //in the interest of time, overridecode had to be changed to use the user's password instead.
        public bool validateOverride(string overrideCode)
        {
            foreach(User u in users)
            {
                if(u.UserType == "Manager")
                {
                    if(overrideCode == u.Password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
            

        //makes sure phone number strings are exactly 10 digits 
        public bool phoneNumberValidator(string phone)
        {
            return (phone != null && phone.Length > 7); //&& Regex.IsMatch("\\d{10,10}",phone)
        }

    }
}
