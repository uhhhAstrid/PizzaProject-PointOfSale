using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace PizzaProject
{
    //Not sure if this class is necessary or not, but we'll find out soon :)
    // Yes, yes it was.
    /* todo: retrieve lastest customerID to ensure all customerID are unique.
     * create orders.json
     * add new orders, matching by phone number
     * same with managers and employees, but those don't change as often.
     */
    public class JSONHandler
    {
        private static string folderPath = "C:\\Users\\" + Environment.UserName + "\\Documents\\PizzaProject";
        private static string customersPath = folderPath + "\\customersJSON.json";
        private static string ordersPath = folderPath + "\\ordersJSON.json";
        private static string usersPath = folderPath + "\\usersJSON.json";

        List<Customer> customers = new List<Customer>(0);
        List<Manager> managers = new List<Manager>(0);
        List<Employee> employees = new List<Employee>(0);

        public JSONHandler(){
            // On Startup, check JSON if exist
            // Read in the current list of orders, customers and leave them in memory
            checkJSON();
            readAllCustomers();
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
            String toBeAdded = JsonConvert.SerializeObject(customers,Formatting.Indented);
            File.WriteAllText(customersPath, toBeAdded);
        }
        // Will overwite current working list with last saved version from disk
        public void readAllCustomers()
        {
            String readCustomers = File.ReadAllText(customersPath);
            this.customers = JsonConvert.DeserializeObject<List<Customer>>(readCustomers);
        }
        public void addOrder(string phoneNumber, Order order)
        {

        }
        ~JSONHandler()
        {
            writeToCustomers();
        }
    }
}
