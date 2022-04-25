using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;

namespace PizzaProject
{
    /* TODO: Figure out why reading and writing cause nulls to happen.
     */
    public class JSONHandler
    {
        private static string folderPath = "C:\\Users\\" + Environment.UserName + "\\Documents\\PizzaProject";
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
            // On Startup, check JSON if exist
            // Read in the current list of orders, customers and leave them in memory
            this.checkJSON();
          
            customers = this.deserializeCustomerList() ?? new List<Customer>(0);
            orders = this.deserializeOrderList() ?? new List<Order>(0);
            users = this.deserializeUserList() ?? new List<User>(0); ;


            Customer.setNextCustomerID(customers.Count);
            Order.setNextOrderID(orders.Count);
            User.setNextUserID(users.Count);
        }

        public void firstRunDataInitialization(int i)
        {
            switch (i)
            {
                //customer initialization
                case 0:
                    {
                        addCustomerToList(new Customer("huan", "3073142718", "hmai10@students.kennesaw.edu", "ga", "tucker", "30084", "marietta pkwy", "no"));
                        addCustomerToList(new Customer("will", "1234567890", "wswift1@students.kennesaw.edu", "credit", "yeff", "1234567890", 420));
                        addCustomerToList(new Customer("will", "1234567891", "tayloswift@kennesaw.edu", "credit", "baylor swift", "1234567890", 421));
                        addCustomerToList(new Customer("well", "9324567891", "carlosswift@kennesaw.edu", "credit", "baylor swift", "1234567890", 422));
                        addCustomerToList(new Customer("swill", "7214567891", "alejandroswift@kennesaw.edu", "credit", "baylor swift", "1234567890", 423));
                        serializeCustomerList();
                        break;
                    }
                //orders initialization
                case 1:
                    {
                        Order testOrderCredit = new Order("credit", true, "3073142718");

                        OrderHandler.currentOrder = testOrderCredit;
                        OrderHandler.AddItemToOrder(new Item("2-Litre", "Pepsi"));
                        OrderHandler.AddItemToOrder(new Item(new List<string> { "Extra-Cheese", "Pepperoni", "Pineapple" }, "Deep Dish", "18"));

                        Order testOrderCash = new Order("cash", false, "1234567890");
                        OrderHandler.currentOrder = testOrderCash;
                        OrderHandler.AddItemToOrder(new Item("Small", "Lemonade"));
                        OrderHandler.AddItemToOrder(new Item(new List<string> { "Mushrooms", "Pineapple"}, "Thin Crust", "12"));

                        addOrderToList(testOrderCredit);
                        addOrderToList(testOrderCash);

                        serializeOrderList();
                        break;
                    }
                //users initialization
                case 2:
                    {
                        addUserToList(new Employee("huan", "password", "quan"));
                        addUserToList(new Manager("tcarreo1", "bruhmoment", "tenonch", 9018));
                        serializeUserList();
                        break;
                    }
            }
        }
        
        protected void checkJSON()
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    for (int i = 0; i < allFiles.Count; i++)
                    {
                        if (!File.Exists(allFiles[i]))
                        {
                            File.Create(allFiles[i]);
                            Thread.Sleep(1000);
                            firstRunDataInitialization(i);
                        }
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
                    throw new Exception("Phone Number is invalid");
                }
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].PhoneNumber == cust.PhoneNumber)
                    {
                        throw new Exception("Customer already exists.");
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
            if (!this.phoneNumberValidator(phone))
            {
                throw new Exception("Phone Number is invalid");
            }
            foreach (Customer c in customers)
            {
                if (c.PhoneNumber == phone)
                {
                    return c;
                }
            }
            return null;
        }

        // ORDER Section
        public void addOrderToList(Order order)
        {
            if (order != null)
            {
                if (!phoneNumberValidator(order.CustomerPhone))
                {
                    throw new Exception("Phone Number is invalid");
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
                    throw new Exception("Customer does not exist.");
                }
                else if (order.Delivery)
                {
                    if (customers[customerIndex].Address.Equals(new Address(customers[customerIndex].PhoneNumber)))
                    {
                        throw new Exception("Customer's address is blank and the order is for deivery");
                    }
                }
                else
                {
                    orders.Add(order);
                }
            }
        }
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
        public void addUserToList(User emp)
        {
            if (emp != null)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].UserID == emp.UserID)
                    {
                        throw new Exception("User already exists.");
                    }
                }
                if (emp.UserName != null && emp.Password != null)
                {
                    users.Add(emp);
                }
                else
                {
                    throw new Exception("User must have a username and password.");
                }
            }
        }
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
        public List<Order> retrieveOrdersByPhoneNumber(string phone)
        {
            if(phone == null && !phoneNumberValidator(phone))
            {
                throw new Exception("Phone Number is invalid");
            }
            List<Order> foundOrders = new List<Order>(0);
            for(int i = 0; i < orders.Count; i++)
            {
                if (orders[i].CustomerPhone.Equals(phone))
                {
                    foundOrders.Add(orders[i]);
                }
            }
            return orders;
        }
        public bool phoneNumberValidator(string phone)
        {
            return (phone != null && Regex.IsMatch("\\d{10,10}",phone));
        }

    }
}
