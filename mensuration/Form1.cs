using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mensuration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double pi = 3.141592653589793;
            richTextBox.AppendText(pi.ToString("n3")+ "\n");
            richTextBox.AppendText(pi.ToString("n5")+"\n");
            richTextBox.AppendText(pi.ToString("n15") + "\n");
            double c = 299792458;
            richTextBox.AppendText(c.ToString("0.0000000") + "\n");
            richTextBox.AppendText(c.ToString("000E0") + "\n");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
