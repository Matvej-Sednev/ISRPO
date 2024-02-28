using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Гороскоп
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dateCurrren = DateTime.Now;
            denSegodna.Text = dateCurrren.ToLongDateString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }


    }
}
