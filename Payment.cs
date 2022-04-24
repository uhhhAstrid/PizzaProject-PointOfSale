using Newtonsoft.Json;

namespace PizzaProject
{
    /// <summary>
    /// Each instance stores Payment information for a single customer instance.
    /// </summary>
    public class Payment
    {
        //fields
        private string cardType;
        private string nameOnCard;
        private string cardNumber;
        private int cvv;
        private string phoneNumber;

            //properties
        [JsonProperty("CardType")]
        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }
        [JsonProperty("NameOnCard")]
        public string NameOnCard
        {
            get { return nameOnCard; }
            set { nameOnCard = value; }
        }
        [JsonProperty("CardNumber")]
        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        [JsonProperty("CVV")]
        public int CVV
        {
            get { return cvv; }
            set { cvv = value; }
        }
        [JsonProperty("CustomerPhone")]
        public string CustomerPhone
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        //constructors
        public Payment(string type, string name, string number, int cv, string phone)
        {
             cardType = type;
            nameOnCard = name;
            cardNumber = number;
            cvv = cv;
            phoneNumber = phone;
        }
        //Blank constructor for customers without stored payment information.
        public Payment(string phone) : this("N/A", "N/A", "N/A", 0, phone)
        {
        }
        public Payment() {}
            //methods
        //sets payment information; use if customer was created without payment info. 
        public void setPayment(string cardType, string nameOnCard, string cardNumber, int cvv, string customerPhone)
        {
            this.cardType = cardType;
            this.nameOnCard = nameOnCard;
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.phoneNumber = customerPhone;
        }
    }
}