namespace PizzaProject
{
    public class User
    {
        protected string username { get; }
        protected string password { get; }
        protected string name { get; }
        protected string userType { get; }
    
        protected User(string user, string pass, string n, string type)
        {
            username = user;
            password = pass;
            name = n;
            userType = type;
        }
    }
}