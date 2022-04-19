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
            //todo Testing JSON Serialization and Deserialization
            Address testAddress = new Address("GA", "atlanta", "30144", "1000 chastain rd", "leave at front desk","1112223333");
            string output = JsonConvert.SerializeObject(testAddress);
            Debug.WriteLine(output);
            
            //Once the following code is run, only events from the GUI will cause the code to progress forward; code after 'Application.Run' will not run until it is closed.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
