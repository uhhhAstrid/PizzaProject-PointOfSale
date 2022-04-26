using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject.GUI_Pages
{
    public partial class ReceiptScreen : Form
    {
        bool creditPayment;

        public ReceiptScreen()
        {
            InitializeComponent();
        }

        public ReceiptScreen(bool credit)
        {
            InitializeComponent();
            creditPayment = credit;
        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //depending on screen, may need to add logic for pop-up menu (this is copy and pasted)
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void ReceiptScreen_Load(object sender, EventArgs e)
        {
            if (creditPayment)
            {
                //add/show signature field
            }

        }

        private void ReceiptScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONHandler j = new JSONHandler();
            j.serializeCustomerList();
            j.serializeOrderList();
            j.serializeUserList();
        }
    }
}
