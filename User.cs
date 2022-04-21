namespace PizzaProject
{
    public class User
    {
            //fields
        //the fields (other than name) cannot be changed after a user is created.
        protected string username { get; }
        protected string password { get; }
        protected string name { get; set;}
        protected string userType { get;}
        protected int userID {get; }
        protected static int nextUserID { get; set; }

            //properties (read-only).
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

            //constructor; creates a new user
        protected User(string user, string pass, string n, string type)
        {
            username = user;
            password = pass;
            name = n;
            userType = type;
            userID = nextUserID++;
        }

            //methods
        //This method is only here as an inside joke. Do not remove. 
        public void setName(string newName)
        {
            name = newName;
        }
    }
}