namespace PizzaProject
{
    public class Employee : User
    {
        static int employeeIDIndex;
        int employeeID;
        
        Employee(string username, string password, string name) : base(username, password, name, "Employee")
        {
            employeeID = employeeIDIndex++;
        }
    }
}