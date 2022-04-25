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
        private static JsonSerializerSettings serializerWithTypesSetting = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All, ObjectCreationHandling = ObjectCreationHandling.Replace };



        List<Customer> customers;
        List<Order> orders;
        //List<Manager> managers = new List<Manager>(0);
        //List<Employee> employees = new List<Employee>(0);
        List<User> users = new List<User>(0);

            //constructor
        public JSONHandler(){
            // On Startup, check JSON if exist
            // Read in the current list of orders, customers and leave them in memory
            this.checkJSON();
            customers = this.readAllCustomers() ?? new List<Customer>(0);
            orders = this.readAllOrders() ?? new List<Order>(0);
            users = this.readUsers() ?? new List<User>(0);
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
                        Thread.Sleep(1000);
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
                List<Customer> existingCustomers = JsonConvert.DeserializeObject<List<Customer>>(readCustomers, serializerWithTypesSetting);
                return existingCustomers;
            }
            catch (Exception ex)
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
