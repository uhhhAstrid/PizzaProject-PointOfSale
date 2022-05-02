using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject.GUI_Pages.PopUp_Pages
{
    public partial class CancelAddCustomer : Form
    {
        public CancelAddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            Owner.Hide();
            this.Close();
        }

    }
}
