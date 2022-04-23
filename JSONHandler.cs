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
     * create orders.json . needs to write and test
     * add new orders, matching by phone number
     * same with managers and employees, but those don't change as often.
     */
    public class JSONHandler
    {
        private static string folderPath = "C:\\Users\\" + Environment.UserName + "\\Documents\\PizzaProject";
        private static string customersPath = folderPath + "\\customersJSON.json";
        private static string ordersPath = folderPath + "\\ordersJSON.json";
        private static string usersPath = folderPath + "\\usersJSON.json";

        List<Customer> customers;
        List<Order> orders;
        List<Manager> managers = new List<Manager>(0);
        List<Employee> employees = new List<Employee>(0);

        public JSONHandler(){
            // On Startup, check JSON if exist
            // Read in the current list of orders, customers and leave them in memory
            this.checkJSON();
            customers = this.readAllCustomers() ?? new List<Customer>(0);
            orders = this.readAllOrders() ?? new List<Order>(0);

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
                if (!File.Exists(customersPath))
                {
                    File.Create(customersPath);
                }
                if (!File.Exists(ordersPath))
                {
                    File.Create(ordersPath);
                }
                if (!File.Exists(usersPath))
                {
                    File.Create(usersPath);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public void addCustomer(Customer cust)
        {
            customers.Add(cust);
        }
        // Overwite the current version on disk with current working list
        public void writeToCustomers()
        {
            try
            {
                String toBeAdded = JsonConvert.SerializeObject(customers, Formatting.Indented);
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
                String readCustomers = File.ReadAllText(customersPath, Encoding.UTF8);
                List<Customer> existingCustomers = JsonConvert.DeserializeObject<List<Customer>>(readCustomers);
                return existingCustomers;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new List<Customer>(0);
            }
        }
        public void addOrder(Order order)
        {
            bool customerFound = false;
            for(int i = 0; i < customers.Count; i++)
            {
                if(customers[i].PhoneNumber != null && customers[i].PhoneNumber.Equals(order.CustomerPhone))
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
                String toBeAdded = JsonConvert.SerializeObject(orders, Formatting.Indented);
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
                return JsonConvert.DeserializeObject<List<Order>>(readOrders);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new List<Order>(0);
            }

        }
    }
}
