using System;
using System.Collections.Generic; //Enables Lists
using System.Windows.Forms; //Built-in C# library for handling GUI
using Newtonsoft.Json; //enables JSON support
using System.Diagnostics; //enables Debug.Write/Debug.Writeline, and other things

namespace PizzaProject
{
    //todo (in Visual Studio) View > Task List; Ctrl + W also works. this makes all //todo show up
    internal static class EntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Menu m = new Menu();
            m.InitializeMenu();

            Manager testManager = new Manager("username", "password", "john", 0010);

            Debug.WriteLine(testManager.Name);
            Debug.WriteLine(testManager.UserID);
            Debug.WriteLine(testManager.UserName);
            Debug.WriteLine(testManager.Password);
            Debug.WriteLine(testManager.ManagerOverrideCode);

            //Once the following code is run, only events from the GUI will cause the code to progress forward; code after 'Application.Run' will not run until it is closed.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
