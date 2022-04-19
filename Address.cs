namespace PizzaProject
{
    /// <summary>
    /// Stores Address information for a customer
    /// </summary>
    public class Address
    {
        private string street { get; }
        private string city { get; }
        private string state { get; }
        private string additionalAddressInfo { get; }
        private string zip { get; }

        //Foreign key, links Address back to specific Customer
        public string customerPhone { get; set; }  

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