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
        public static string user = "dancer_dana";
        public static string pass = "5678";

        public Form1()
        {
            InitializeComponent();

            LoginScreen ls = new LoginScreen();
            this.Controls.Add(ls);
        }
    }
}
