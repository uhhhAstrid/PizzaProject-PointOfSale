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
        ViewCustomersScreen screen;
        public ManagerOverrideRequest()
        {
            InitializeComponent();
        }

        public ManagerOverrideRequest(ViewCustomersScreen screen)
        {
            InitializeComponent();
            this.screen = screen;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            JSONHandler j = new JSONHandler();


            if (j.validateOverride(overrideField.Text))
            {
                screen.managerOverrideValidated();
                this.Close();
            }
            else
            {
                this.Hide();
                var invalidOverridePopUp = new InvalidManagerOverride();
                invalidOverridePopUp.ShowDialog();
            }

        }
    }
}
