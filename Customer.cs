namespace PizzaProject {
    public class Customer
    {
        //todo add properties and constructor
        private int customerID { get; }
        private string name { get; set; }
        private string phoneNumber { get; set; }
        private Payment payment { get; }
        private Address address { get; }

        //todo Create new Payment given the necessary information
        void setPayment(string cardType, string nameOnCard, string cardNumber, int cvv, string customerPhone) 
        {

        }
    }
}