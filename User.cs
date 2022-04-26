using Newtonsoft.Json;
namespace PizzaProject
{
    public class User
    {
        //fields
        //the fields (other than name) cannot be changed after a user is created.
        protected string username;
        protected string password;
        protected string name;
        protected string userType;
        protected int userID;
        protected static int nextUserID;

            //properties 
        [JsonProperty("Name")]
        public string Name   
        {
            get { return name; }
            set { name = value; }
        }
        [JsonProperty("UserName")]
        public string UserName   
        {
            get { return username; }
            set { username = value; }
        }
        [JsonProperty("Password")]
        public string Password   
        {
            get { return password ; }
            set { password = value; }
        }
        [JsonProperty("UserType")]
        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }
        [JsonProperty("UserID")]
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
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
        public static void setNextUserID(int newID)
        {
            nextUserID = newID;
        }

            //methods
        //sentimental method. please do not remove. 
        public void setName(string newName)
        {
            name = newName;
        }
    }
}