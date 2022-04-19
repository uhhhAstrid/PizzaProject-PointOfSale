namespace PizzaProject
{
    public class Manager : User
    {
        int managerOverrideCode;
        public int ManagerOverrideCode
        {
            get { return managerOverrideCode; }
        }

        /*
         * calls parent (User) and passes username, password, name, and usertype, creating a new User with those details;
         * also creates a new manager with managerID and managerOverride 
        */

        public Manager(string username, string password, string name, int managerOverride) : base(username, password, name, "Manager")
        {
            managerOverrideCode = managerOverride;
        }
    }
}