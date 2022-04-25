using System;
using System.Collections.Generic;
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
        // Visual Studio Generated Equals and HashCode, used for comparing Address
        public override bool Equals(object obj)
        {
            return obj is Address address &&
                   street == address.street &&
                   city == address.city &&
                   state == address.state &&
                   additionalAddressInfo == address.additionalAddressInfo &&
                   zip == address.zip &&
                   customerPhone == address.customerPhone &&
                   Street == address.Street &&
                   State == address.State &&
                   City == address.City &&
                   AdditionalAddressInfo == address.AdditionalAddressInfo &&
                   Zip == address.Zip;
        }

        public override int GetHashCode()
        {
            int hashCode = 1543575263;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(street);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(city);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(state);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(additionalAddressInfo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(zip);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(customerPhone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Street);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(State);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(City);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AdditionalAddressInfo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Zip);
            return hashCode;
        }
    }
}