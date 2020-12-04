using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poundtokg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Pound = (double)numericUpDown1.Value;
            double Answer = Pound * 0.453592;
            label4.Text = Answer.ToString() + " kgs";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double KG = (double)numericUpDown2.Value;
            double Answer2 = KG * 2.20462;
            label4.Text = Answer2.ToString() + " lbs"; 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            label4.Text = "Answer";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
