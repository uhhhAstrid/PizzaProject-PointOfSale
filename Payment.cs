namespace PizzaProject
{
    public class Payment
    {
        private string cardType { get; set; }
        private string nameOnCard { get; set; }
        private string cardNumber { get; set; }
        private int cvv { get; set; }
        public string customerPhone { get; set; }

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