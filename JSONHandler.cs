using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

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

        List<Customer> customers;
        List<Order> orders;
        List<User> users;

            //constructor
        public JSONHandler(){
            // On Startup, check JSON if exist
            // Read in the current list of orders, customers and leave them in memory
            this.checkJSON();
          
            customers = this.readAllCustomers();
            orders = this.readAllOrders();
            users = this.readAllUsers();


            Customer.setNextCustomerID(customers.Count);
            Order.setNextOrderID(orders.Count);
            User.setNextUserID(users.Count);
        }
        protected void checkJSON()
        {
            try
            {
                if (!System.IO.Directory.Exists(folderPath))
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                }
                for(int i = 0; i < allFiles.Count; i++)
                {
                    if (!File.Exists(allFiles[i]))
                    {
                        File.Create(allFiles[i]);
                        Thread.Sleep(1000);
                    }
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public void addCustomer(Customer cust)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].PhoneNumber == cust.PhoneNumber)
                    throw new Exception("Customer already exists.");
            }
            if (cust != null)
                customers.Add(cust);
        }
        // Overwite the current version on disk with current working list
        public void writeToCustomers()
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
        // Will overwite current working list with last saved version from disk
        public List<Customer> readAllCustomers()
        {
            try
            {
                String readCustomers = System.IO.File.ReadAllText(customersPath);
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
        public void addOrder(Order order)
        {
            if (order != null)
            {
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
        public void writeToOrders()
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
        protected List<Order> readAllOrders()
        {
            try
            {
                String readOrders = File.ReadAllText(ordersPath);
                return JsonConvert.DeserializeObject<List<Order>>(readOrders, serializerWithTypesSetting);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
                return new List<Order>(0);
            }
        }
        // Users Section
        public void addUser(User emp)
        {
            if (emp != null)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].UserID == emp.UserID)
                        throw new Exception("User already exists.");
                }
                if (emp.UserName != null && emp.Password != null)
                    users.Add(emp);
            }
        }
        public void writeToUsers()
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
        protected List<User> readAllUsers()
        {
            try
            {
                String existingUsers = File.ReadAllText(usersPath);
                var processed = JsonConvert.DeserializeObject<List<User>>(existingUsers, serializerWithTypesSetting);
                return processed;
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("Could not load users file.");
                return new List<User>(0);
            }
        }
        public void phoneNumberValidator(String phone)
        {
            //var re = "/ ^([+] ? 1[\s] ?) ? ((?:[(](?:[2 - 9]1[02 - 9] |[2 - 9][02 - 8][0 - 9])[)][\s]?)| (?: (?:[2 - 9]1[02 - 9] |[2 - 9][02 - 8][0 - 9])[\s.-]?)){ 1} ([2 - 9]1[02 - 9] |[2 - 9][02 - 9]1 |[2 - 9][02 - 9]{ 2}[\s.-]?){ 1} ([0 - 9]{ 4}){ 1}$/";
            //return re.test(str);
        }

    }
}
