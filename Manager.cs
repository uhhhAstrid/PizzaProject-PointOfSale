namespace PizzaProject
{
    public class Manager : User
    {
        static int managerIDIndex = 0;
        int managerID { get; }
        int managerOverrideCode { get; }

        //calls parent (User) and passes username, password, name, and usertype, creating a new User with those details; also creates a new manager with managerID and managerOverride
        Manager(string username, string password, string name, int managerOverride) : base(username, password, name, "Manager")
        {
            managerOverrideCode = managerOverride;
            managerID = managerIDIndex++;
        }
    }
}