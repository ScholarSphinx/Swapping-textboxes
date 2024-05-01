using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //swap values between textboxes
            //Involves having a temporary variable to store one of the values
            //Inputs : TextBox1 - m; TextBox2 - n; Temp -
            string temp = textBox1.Text;
            //First line: TextBox1 - m; Textbox2 - n; Temp - m
            textBox1.Text = textBox2.Text;
            //Second line: Textbox1 - n; Textbox2 - n; Temp - m
            textBox2.Text = temp;
            //Third line: Textbox1 - n; Textbox2 - m; Temp - m
        }
    }
}
