using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_WordCountXDisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCountWords_Click(object sender, EventArgs e)
        {
            string words = txtString.Text.Trim();
            MessageBox.Show("Number of Words: " + CountWords(words));

            textBox2.Text = txtString.Text;
        }

        private int CountWords(string words)
        {
            string[] allWords = words.Split (' ');
            return allWords.Length;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
