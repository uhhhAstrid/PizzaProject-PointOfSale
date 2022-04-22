using System;
using Newtonsoft.Json;
  

namespace PizzaProject
{
    /// <summary>
    /// Each instance stores address information for a single customer instance. 
    /// </summary>
    public class Address
    {
          //fields
        private string street { get; set; }
        private string city { get; set; }
        private string state { get; set; }
        private string additionalAddressInfo { get; set; }
        private string zip { get; set; }

        //Foreign key, links Address back to specific Customer
        public string customerPhone { get; set; }

            //properties
        public string Street
        {
            get { return street; }
        }
        public string State
        {
            get { return state; }
        }
        public string City
        {
            get { return city; }
        }
        public string AdditionalAddressInfo
        {
            get { return additionalAddressInfo; }
        }
        public string Zip
        {
            get { return zip; }
        }

        //constructors
        [JsonConstructor]
        public Address(string state, string city, string zip, string street, string additionalInfo, string phone)
        {
            this.state = state;
            this.city = city;
            this.zip = zip;
            this.street = street;
            additionalAddressInfo = additionalInfo;
            customerPhone = phone;
        }
        public Address(string phone)
        {
            state = "";
            city = "";
            zip = "";
            street = "";
            additionalAddressInfo = "";
            customerPhone = phone;
        }
          
            //methods
        //sets address information; use if customer was created without address info. 
        public void setAddress(string state, string city, string zip, string street, string additionalInfo, string customerPhone)
        {
            this.state = state;
            this.city = city;
            this.zip = zip;
            this.street = street;
            this.additionalAddressInfo = additionalInfo;
            this.customerPhone = customerPhone;
        }
    }
}