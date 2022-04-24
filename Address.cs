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
        private string street;
        private string city;
        private string state;
        private string additionalAddressInfo;
        private string zip;

        //Foreign key, links Address back to specific Customer
        [JsonProperty("customerPhone")]
        public string customerPhone;
        //properties
        [JsonProperty("Street")]
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        [JsonProperty("State")]
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        [JsonProperty("City")]
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        [JsonProperty("AdditionalAddressInfo")]
        public string AdditionalAddressInfo
        {
            get { return additionalAddressInfo; }
            set { additionalAddressInfo = value; }
        }
        [JsonProperty("Zip")]
        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        //constructors
        public Address(){}
        public Address(string state, string city, string zip, string street, string additionalInfo, string phone)
        {
            this.state = state;
            this.city = city;
            this.zip = zip;
            this.street = street;
            additionalAddressInfo = additionalInfo;
            customerPhone = phone;
        }
        public Address(string phone) : this("GA", "N/A", "N/A", "N/A", "N/A", phone)
        {
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