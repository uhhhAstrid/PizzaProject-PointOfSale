using Newtonsoft.Json;
namespace PizzaProject
{
    /// <summary>
    /// Creates new Manager instances, retrieves manager information during runtime.
    /// </summary>
    public class Manager : User
    {
        private int managerOverrideCode;
        [JsonProperty("ManagerOverrideCode")]
        public int ManagerOverrideCode
        {
            get { return managerOverrideCode; }
            set { managerOverrideCode = value; }
        }
        //calls parent (User) and passes username, password, name, and usertype, creating a new User with those details;
        //also creates a new manager with managerID and managerOverride
        public Manager(string username, string password, string name, int managerOverride) : base(username, password, name, "Manager")
        {
            managerOverrideCode = managerOverride;
        }
    }
}