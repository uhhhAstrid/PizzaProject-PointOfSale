using Newtonsoft.Json;

namespace PizzaProject
{
    /// <summary>
    /// Each instance stores Payment information for a single customer instance.
    /// </summary>
    public class Payment
    {
            //fields
        private string cardType { get; set; }
        private string nameOnCard { get; set; }
        private string cardNumber { get; set; }
        private int cvv { get; set; }
        public string customerPhone { get; set; }

            //properties
        public string CardType
        {
            get { return cardType; }
        }
        public string NameOnCard
        {
            get { return nameOnCard; }
        }
        public string CardNumber
        {
            get { return cardNumber; }
        }
        public int CVV
        {
            get { return cvv; }
        }
        public string CustomerPhone
        {
            get { return customerPhone; }
        }

        //constructors
        [JsonConstructor]
        public Payment(string type, string name, string number, int cv, string phone)
        {
            cardType = type;
            nameOnCard = name;
            cardNumber = number;
            cvv = cv;
            customerPhone = phone;
        }
        //Blank constructor for customers without stored payment information.
        public Payment(string phone)
        {
            cardType = "";
            nameOnCard = "";
            cardNumber = "";
            cvv = 0;
            customerPhone = phone;
        }

            //methods
        //sets payment information; use if customer was created without payment info. 
        public void setPayment(string cardType, string nameOnCard, string cardNumber, int cvv, string customerPhone)
        {
            this.cardType = cardType;
            this.nameOnCard = nameOnCard;
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.customerPhone = customerPhone;
        }
    }
}