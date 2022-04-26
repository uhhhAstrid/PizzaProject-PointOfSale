using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject.GUI_Pages.PopUp_Pages
{
    public partial class AddDrinkWindow : Form
    {
        MakeOrderScreen screen;
        Item item;

        public AddDrinkWindow()
        {
            InitializeComponent();
        }

        public AddDrinkWindow(Item item, MakeOrderScreen screen)
        {
            InitializeComponent();
            this.item = item;
            this.screen = screen;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string flavor = flavorBox.SelectedItem.ToString();
            string size = sizeBox.SelectedItem.ToString();
            item.setSize(size);
            item.setFlavor(flavor);
            screen.GetDataFromPopup(item);
            this.Close();
        }
    }
}
