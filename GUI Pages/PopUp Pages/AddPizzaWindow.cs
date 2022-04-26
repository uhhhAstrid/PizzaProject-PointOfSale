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
    public partial class AddPizzaWindow : Form
    {
        MakeOrderScreen screen;
        Item item;

        public AddPizzaWindow()
        {
            InitializeComponent();
        }

        public AddPizzaWindow(Item item, MakeOrderScreen screen)
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
            string crust = crustBox.SelectedItem.ToString();
            string size = sizeBox.SelectedItem.ToString();
            item.Toppings = compileToppingList(item);
            item.setSize(size);
            item.setCrustType(crust);
            screen.GetDataFromPopup(item);
            this.Close();
        }

        //very rough implementation; can be cleaned significantly
        //the multi-checkbox tool didn't support multiple checks... 
        //why is it the multi-checkbox tool?
        private List<string> compileToppingList(Item i)
        {

            if (cheese.Checked)
            {
                i.Toppings.Add("Extra Cheese");
            }
            if (Pepperoni.Checked)
            {
                i.Toppings.Add("Pepperoni");
            }
            if (Mushrooms.Checked)
            {
                i.Toppings.Add("Mushrooms");
            }
            if (Onions.Checked)
            {
                i.Toppings.Add("Onions");
            }
            if (sausage.Checked)
            {
                i.Toppings.Add("Sausage");
            }
            if (bacon.Checked)
            {
                i.Toppings.Add("Bacon");
            }
            if (blackOlives.Checked)
            {
                i.Toppings.Add("Black Olives");
            }
            if (greenPeppers.Checked)
            {
                i.Toppings.Add("Green Peppers");
            }
            if (pineapple.Checked)
            {
                i.Toppings.Add("Pineapple");
            }
            if (spinach.Checked)
            {
                i.Toppings.Add("Spinach");
            }
            if (jalapenos.Checked)
            {
                i.Toppings.Add("Jalapenos");
            }
            if (ham.Checked)
            {
                i.Toppings.Add("Ham");
            }
            return i.Toppings;
        }
    }
}
