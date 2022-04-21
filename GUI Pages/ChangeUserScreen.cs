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
            //temp code; shows error pop-up
            var changeUserPopup = new ChangeUserInvalidLogin();
            changeUserPopup.ShowDialog();
            //verify username and password with the User JSON information
            //loop through users in JSON, if username matches:
                //if (password.equals) : log-in user
                    //log-in user: log-out current user, set current user to user.Name, set current user type to user.Usertype
                //else () : throw error: 'password incorrect'
            //else 'no users found with that username'

        }

        private void returnToHome_Click(object sender, EventArgs e)
        {
            //depending on screen, may need to add logic for pop-up menu (this is copy and pasted)
            var homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }
    }
}
