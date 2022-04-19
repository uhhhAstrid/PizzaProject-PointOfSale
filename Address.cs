namespace PizzaProject
{
    /// <summary>
    /// Stores Address information for a customer
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
            set { street = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string AdditionalAddressInfo
        {
            get { return additionalAddressInfo; }
            set { additionalAddressInfo = value; }
        }
        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public Address(string state, string city, string zip, string street, string additionalInfo, string phone)
        {
            this.state = state;
            this.city = city;
            this.zip = zip;
            this.street = street;
            additionalAddressInfo = additionalInfo;
            customerPhone = phone;
        }
    }
}