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
    public partial class OrderSearchComplete : Form
    {
        int ordersfound;
        public OrderSearchComplete()
        {
            InitializeComponent();
        }

        public OrderSearchComplete(int ordersfound)
        {
            InitializeComponent();
            this.ordersfound = ordersfound;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void OrderSearchComplete_Load(object sender, EventArgs e)
        {
            numOrdersFound.Text = ordersfound.ToString();
        }
    }
}
