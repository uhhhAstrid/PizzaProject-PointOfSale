using PizzaProject.GUI_Pages.PopUp_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            JSONHandler j = new JSONHandler();
            if(j.validateUserLogin(usernameField.Text, passwordField.Text))
            {
                this.Hide();
                var homescreen = new HomeScreen();
                homescreen.Show();
            }
            else
            {
                var invalidLogin = new ChangeUserInvalidLogin();
                invalidLogin.ShowDialog();
            }

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void LoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONHandler j = new JSONHandler();
            j.serializeCustomerList();
            j.serializeOrderList();
            j.serializeUserList();
            Application.Exit();
        }
    }
}
