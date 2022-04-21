using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace PizzaProject
{
    //Not sure if this class is necessary or not, but we'll find out soon :)
    public class JSONHandler
    {

        private string orderDBPath = "whatever the file path is";
        private string customerDBPath = "whatever the file path is";
        private string userDBPath = "whatever the file path is";

        public void orderJSON(List<Order> orders, string type)
        {
            if (type == "read" || type == "Read")
            {
               JsonConvert.SerializeObject(orders);
            }
            if (type == "write" || type == "Write")
            {
                JsonConvert.DeserializeObject(Order);
                return list of Orders;
            }
        }
    
        

        public void customerJSON(List<Customer> customers, string type)
        {
            if (type == "read" || type == "Read")
            {
                JsonConvert.SerializeObject(customers);
            }
            if (type == "write" || type == "Write")
            {
                JsonConvert.DeserializeObject();
                return list of Customers;

            }
        }

        public void userJSON(List<User> users, string type)
        {
            if (type == "read" || type == "Read")
            {
                JsonConvert.SerializeObject(users);
            }
            if (type == "write" || type == "Write")
            {
                JsonConvert.DeserializeObject(User);
                return list of Users;

            }
        }

        public void checkJSONFile()
        {
            try
            {
                if (File.Exists(orderDBPath) == false)
                {
                    File.Create(orderDBPath);
                }
            }
            catch { }
            try
            {
                if (File.Exists(customerDBPath) == false)
                {
                    File.Create(customerDBPath);
                }
            }
            catch { }
            try
            {
                if (File.Exists(userDBPath) == false)
                {
                    File.Create(userDBPath);
                }
            }
            catch { }
        }
    }
}
