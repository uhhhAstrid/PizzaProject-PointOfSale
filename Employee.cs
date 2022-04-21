namespace PizzaProject
{
    /// <summary>
    /// Creates new Employee instances.
    /// </summary>
    public class Employee : User
    {
        //Creates a new employee by calling the User class; this is complete. 
        public Employee(string username, string password, string name) : base(username, password, name, "Employee")
        {
        
        }
    }
}