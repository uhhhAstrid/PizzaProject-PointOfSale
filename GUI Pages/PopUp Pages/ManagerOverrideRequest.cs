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
    public partial class ManagerOverrideRequest : Form
    {
        public ManagerOverrideRequest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //temporary popup for invalid override code
            var invalidOverridePopUp = new InvalidManagerOverride();
            invalidOverridePopUp.ShowDialog();
        }
    }
}
