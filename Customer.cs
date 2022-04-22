using Newtonsoft.Json;

namespace PizzaProject {

    /// <summary>
    /// This class handles creating new customer instances, 
    /// adding payment and address information to customers, 
    /// and returning information from a customer during runtime.
    /// </summary>
    public class Customer
    {
            //fields
        private int customerID { get; set; }
        private static int nextCustomerID { get; set; }
        private string name { get; set; }
        private string phoneNumber { get; set; }
        private string email { get; set; }
        private Payment payment { get; }
        private Address address { get; }

            //properties
        public int CustomerID { get { return customerID; } }
        public string Name { get { return name; } }
        public string PhoneNumber { get { return phoneNumber; } }
        public string Email { get { return email; } }
        public Payment Payment { get { return payment; } }
        public Address Address { get { return address; } }

            //constructors
        //new customer with no payment or address info
        public Customer(string name, string phone, string email)
        {
            customerID = nextCustomerID++;
            this.name = name;
            this.email = email;
            payment = new Payment(phone);
            address = new Address(phone);
        }
        //new customer with payment info, but not address info
        public Customer(string name, string phone, string email, string cardType, string nameOnCard, string cardNumber, int cvv)
        {
            customerID = nextCustomerID++;
            this.name = name;
            this.email = email;
            payment = new Payment(cardType, nameOnCard, cardNumber, cvv, phone);
            address = new Address(phone);
        }
        //new customer with address info, but not payment info
        public Customer(string name, string phone, string email, string state, string city, string zip, string street, string additionalInfo)
        {
            customerID = nextCustomerID++;
            this.name = name;
            this.email = email;
            payment = new Payment(phone);
            address = new Address(state, city, zip, street, additionalInfo, phone);
        }
        [JsonConstructor]
        //new customer with both payment and address info
        public Customer(string name, string phone, string email, string cardType, string nameOnCard, string cardNumber, int cvv, string state, string city, string zip, string street, string additionalInfo)
        {
            customerID = nextCustomerID++;
            this.name = name;
            this.email = email;
            payment = new Payment(cardType, nameOnCard, cardNumber, cvv, phone);
            address = new Address(state, city, zip, street, additionalInfo, phone);
        }
       
            //methods
        //every customer is created with a blank payment and address unless that information is provided;
        //these two methods simply change the blank information in each field to the correct information.
        //customers cannot have partial payment or address information
        void setPayment(string cardType, string nameOnCard, string cardNumber, int cvv, string customerPhone) 
        {
            payment.setPayment(cardType, nameOnCard, cardNumber, cvv, customerPhone);
        }
        void setAddress(string state, string city, string zip, string street, string additionalInfo, string customerPhone)
        {
            address.setAddress(state, city, zip, street, additionalInfo, customerPhone);
        }
    }
}