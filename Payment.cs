namespace PizzaProject
{
    //todo: properties
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
            set { cardType = value; }
        }
        public string NameOnCard
        {
            get { return nameOnCard; }
            set { nameOnCard = value; }
        }
        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        public int CVV
        {
            get { return cvv; }
            set { cvv = value; }
        }
        public string CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }

        //constructor
        public Payment(string type, string name, string number, int cv, string phone)
        {
            cardType = type;
            nameOnCard = name;
            cardNumber = number;
            cvv = cv;
            customerPhone = phone;
        }
    }
}