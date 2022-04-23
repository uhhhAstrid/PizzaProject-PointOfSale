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
        private int customerID;
        private static int nextcustomerID;
        private string name;
        private string phoneNumber;
        private string email;
        private Payment payment;
        private Address address;

        //properties
        [JsonProperty("CustomerID")]
        public int CustomerID { get { return customerID; } }
        [JsonProperty("Name")]
        public string Name { get { return name; } }
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber { get { return phoneNumber; } }
        [JsonProperty("Email")]
        public string Email { get { return email; } }
        [JsonProperty("Payment")]
        public Payment Payment { get { return payment; } }
        [JsonProperty("Address")]
        public Address Address { get { return address; } }


            //constructors
        //new customer with no payment or address info
        public Customer(string name, string phone, string email)
        {
            customerID = nextcustomerID++;
            this.name = name;
            this.email = email;
            this.phoneNumber = phone;
            payment = new Payment(phone);
            address = new Address(phone);
        }
        //new customer with payment info, but not address info
        public Customer(string name, string phone, string email, string cardType, string nameOnCard, string cardNumber, int cvv) : this(name, phone, email)
        {
            //customerID = nextcustomerID++;
            //this.name = name;
            //this.email = email;
            //address = new Address(phone);
            payment = new Payment(cardType, nameOnCard, cardNumber, cvv, phone);
        }
        //new customer with address info, but not payment info
        public Customer(string name, string phone, string email, string state, string city, string zip, string street, string additionalInfo): this(name, phone, email)
        {
            //customerID = nextcustomerID++;
            //this.name = name;
            //this.email = email;
            //payment = new Payment(phone);
            address = new Address(state, city, zip, street, additionalInfo, phone);
        }
        //new customer with both payment and address info
        [JsonConstructor]
        public Customer(string name, string phone, string email, string cardType, string nameOnCard, string cardNumber, int cvv, string state, string city, string zip, string street, string additionalInfo)
        {
            customerID = nextcustomerID++;
            this.name = name;
            this.email = email;
            this.phoneNumber = phone;
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
        public static void setNextCustomerID(int id) => nextcustomerID = id;

        public override string ToString()
        {
            return base.ToString() ;
        }
    }
}