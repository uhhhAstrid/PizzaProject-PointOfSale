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
    public partial class FinalizeOrder : Form
    {
        public FinalizeOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //todo: finalize order popup logic
            //take relevant order data and pass to payment screen, load payment screen 
            var paymentScreen = new ProcessPaymentScreen();
            paymentScreen.Show();
            Owner.Hide();
            this.Hide();
            
        }

    }
}
