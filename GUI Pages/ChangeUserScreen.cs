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

namespace PizzaProject.GUI_Pages
{
    public partial class ChangeUserScreen : Form
    {
        public ChangeUserScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            JSONHandler j = new JSONHandler();
            if(j.validateUserLogin(usernameField.Text, passwordField.Text))
            {
                var changeUserConfirmation = new LogOutAlert();
                changeUserConfirmation.ShowDialog();
                changeUserSuccess.Text = "Successfully logged in as " + usernameField.Text;
            }
            else
            {
                var changeUserPopup = new ChangeUserInvalidLogin();
                changeUserPopup.ShowDialog();
            }
        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void ChangeUserScreen_Load(object sender, EventArgs e)
        {

        }

        private void ChangeUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONHandler j = new JSONHandler();
            j.serializeCustomerList();
            j.serializeOrderList();
            j.serializeUserList();
            Application.Exit();
        }
    }
}
