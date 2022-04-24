using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace PizzaProject
{
    //Not sure if this class is necessary or not, but we'll find out soon :)
    // Yes, yes it was.
    /* todo: retrieve latest customerID to ensure all customerID are unique. done
     * create orders.json. done
     * add new orders, matching by phone number done 
     * same with managers and employees, but those don't change as often.
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

        public JSONHandler(){
            // On Startup, check JSON if exist
            // Read in the current list of orders, customers and leave them in memory
            this.checkJSON();
            customers = this.readAllCustomers() ?? new List<Customer>(0);
            orders = this.readAllOrders() ?? new List<Order>(0);
            users = this.readUsers() ?? new List<User>(0);


            Customer.setNextCustomerID(customers.Count);
            Order.setNextOrderID(orders.Count);
        }
        public void checkJSON()
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
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public void addCustomer(Customer cust)
        {
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
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        // Will overwite current working list with last saved version from disk
        public List<Customer> readAllCustomers()
        {
            try
            {
                String readCustomers = File.ReadAllText(customersPath) ;
                List<Customer> existingCustomers = JsonConvert.DeserializeObject<List<Customer>>(readCustomers);
                return existingCustomers;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new List<Customer>(0);
            }
        }
        // ORDER Section
        public void addOrder(Order order)
        {
            if (order != null) { }
            bool customerFound = false;
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].PhoneNumber != null && customers[i].PhoneNumber.Equals(order.CustomerPhone))
                {
                    orders.Add(order);
                    customerFound = true;
                }
            }
            if (!customerFound)
                Debug.WriteLine("Customer does not exist");
        }
        public void writeToOrders()
        {
            try
            {
                String toBeAdded = JsonConvert.SerializeObject(orders, Formatting.Indented, serializerWithTypesSetting);
                File.WriteAllText(ordersPath, toBeAdded);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public List<Order> readAllOrders()
        {
            try
            {
                String readOrders = File.ReadAllText(ordersPath);
                return JsonConvert.DeserializeObject<List<Order>>(readOrders, serializerWithTypesSetting);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new List<Order>(0);
            }
        }
        // Users Section
        public void addUser(User emp)
        {
            if (emp != null && emp.UserName != null && emp.Password != null)
                users.Add(emp);
        }
        public void writeToUsers()
        {
            try
            {
                var usersToBeSaved = JsonConvert.SerializeObject(users,Formatting.Indented,serializerWithTypesSetting);
                File.WriteAllText(usersPath,usersToBeSaved);
            }
            catch (Exception ex){ 
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("Could not write users file.");
            }
        }
        public List<User> readUsers()
        {
            try
            {
                String existingUsers = File.ReadAllText(usersPath);
                var processed = JsonConvert.DeserializeObject<List<User>>(existingUsers, serializerWithTypesSetting);
                return processed;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine("Could not load users file.");
                return new List<User>(0);
            }
        }

    }
}
