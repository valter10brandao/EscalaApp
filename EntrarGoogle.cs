using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalaApp
{
    public partial class EntrarGoogle : Form
    {
        public EntrarGoogle()
        {
            InitializeComponent();
        }

        private void EntrarGoogle_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com.br");
        }
    }
}
