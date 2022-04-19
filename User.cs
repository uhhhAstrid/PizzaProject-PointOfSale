namespace PizzaProject
{
    public class User
    {
        //fields
        protected string username { get; }
        protected string password { get; }
        protected string name { get; }
        protected string userType { get; }
        protected int userID { get; }
        protected static int nextUserID { get; set; }

        //properties
        public string Name   
        {
            get { return name; }

        }
        public string UserName   
        {
            get { return username; }

        }
        public string Password   
        {
            get { return name; }

        }

        public string UserType
        {
            get { return userType; }
        }

        public int UserID
        {
            get { return userID; }
        }

        //constructor
        protected User(string user, string pass, string n, string type)
        {
            username = user;
            password = pass;
            name = n;
            userType = type;
            userID = nextUserID++;
        }
    }
}