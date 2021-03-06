using Newtonsoft.Json;
namespace PizzaProject
{
    /// <summary>
    /// Creates new Manager instances, retrieves manager information during runtime.
    /// </summary>
    public class Manager : User
    {
        //calls parent (User) and passes username, password, name, and usertype, creating a new User with those details;
        //also creates a new manager with managerID and managerOverride
        public Manager(string username, string password, string name) : base(username, password, name, "Manager")
        {
        }
    }
}