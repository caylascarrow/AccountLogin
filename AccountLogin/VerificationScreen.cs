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
    public partial class VerificationScreen : UserControl
    {
        public VerificationScreen()
        {
            InitializeComponent();
            verificationOutput.Text = "Welcome! " + Form1.user;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            f.Close();
        }
    }
}
