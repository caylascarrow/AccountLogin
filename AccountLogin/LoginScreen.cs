using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountLogin
{
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void verifyAccount_Click(object sender, EventArgs e)
        {
            //check if username and password inputted matches
            if (usernameInput.Text == Form1.user && passwordInput.Text == Form1.pass)
            {
                //if matches, move to next screen and remove old form
                Form f = this.FindForm();
                f.Controls.Remove(this);

                VerificationScreen vs = new VerificationScreen();
                f.Controls.Add(vs);
            }
            else
            {
                //if username didn't match up, send error message
                wrongInput.Text = "The information you have inputted is incorrect. Please check your username and password.";
            }
        }
    }
}
