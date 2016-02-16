using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountLogin
{
    public partial class Form1 : Form
    {
        //added username and password as global strings
        public static string user = "dancer_dana";
        public static string pass = "5678";

        public Form1()
        {
            InitializeComponent();

            //change to login screen
            LoginScreen ls = new LoginScreen();
            this.Controls.Add(ls);
        }
    }
}
