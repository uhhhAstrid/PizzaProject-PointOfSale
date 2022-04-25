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
            //initializes the current menu offerings
            Menu m = new Menu();
            Menu.InitializeMenu();
            
            //initializes the data stored in JSON; creating dummy data if none is present
            JSONHandler handler = new JSONHandler();

            //Once the following code is run, only events from the GUI will cause the code to progress forward;
            //because "EntryPoint" is single threaded
            //code after 'Application.Run' will not run until it is closed.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeScreen());
        }
    }
}
