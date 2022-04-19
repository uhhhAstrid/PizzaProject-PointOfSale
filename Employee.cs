namespace PizzaProject
{
    public class Employee : User
    {
        
        public Employee(string username, string password, string name) : base(username, password, name, "Employee")
        {
        
        }
    }
}