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
            if (usernameInput.Text == Form1.user && passwordInput.Text == Form1.pass)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                VerificationScreen vs = new VerificationScreen();
                f.Controls.Add(vs);
            }
            else
            {
                wrongInput.Text = "The information you have inputted is incorrect. Please check your username and password.";
            }
        }
    }
}
