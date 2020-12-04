using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_ModeMedian
{
    public partial class Form1 : Form
    {
        List<double> values;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            values = new List<double>();
        }

        void ShowValues()
        {
            lbxValues.Items.Clear();

            for (int i = 0; i < values.Count; i++)
                lbxValues.Items.Add(values[i]);

            lblCount.Text = values.Count.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            values.Clear();
            lbxValues.Items.Clear();

            txtValue.Text = "";
            txtMean.Text = "";
            txtMedian.Text = "";
            txtStandardDev.Text = "";
            txtVariance.Text = "";
            txtValue.Focus();
            txtMode.Text = "";


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // This the value that will be added to the text box
            double value = 0.00;
            double sum = 0.00, sumSquares = 0.00, squareSums, mean = 0.00;
            double median = 0.00;
            double stdDev = 0.00;
            double Variance = 0.00;

            // Check that the user entered a value in the text box
            if (txtValue.Text.Length == 0)
            {
                MessageBox.Show("You must enter a value.", "Measures of Center");
                return;
            }

            try
            {
                // Get the value the user entered
                value = double.Parse(txtValue.Text);
                // Add it to the collection
                values.Add(value);
                // Show the values in the list box
                ShowValues();

                txtValue.Text = "";
                txtValue.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("The value you entered is invalid.",
                                "Probability Distribution");
            }

            // Calculate the total
            for (int i = 0; i < values.Count; i++)
                sum += values[i];
            squareSums = sum * sum;
            for (int i = 0; i < values.Count; i++)
                sumSquares += (values[i] * values[i]);
            // Calculate the mean
            mean = sum / values.Count;

            // Get ready to evaluate the median
            // First sort the list
            values.Sort();

            // Find out if the list is odd
            if ((values.Count % 2) == 0)
            {
                double midIndex = values.Count / 2;
                median = (values[(int)(midIndex - 0.5)] +
                      values[(int)(midIndex + 0.5)]) / 2;
            }
            else
                median = values[values.Count / 2];


           

            



            double numerator = values.Count * sumSquares - squareSums;
            double denominator = values.Count * (values.Count - 1);
            stdDev = Math.Sqrt(numerator / denominator);

            Variance = (stdDev * stdDev);
            // Display the values
            
            txtMean.Text = mean.ToString("F");
            txtMedian.Text = median.ToString("F");
            txtStandardDev.Text = stdDev.ToString("F");
            txtVariance.Text = Variance.ToString("F");
            txtMode.Text = Convert.ToString(mode2());
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private double mode2()
        {
            //Dictionary to hold the number of values for a key.
            Dictionary<double, int> dict = new Dictionary<double, int>();
            double mode = 0.00;
            int max = 0;
            foreach (double key in values)
            {
                if (!dict.ContainsKey(key))
                    dict.Add(key, 1);
                else
                    dict[key] += 1;

                if (dict[key] > max)
                    max = dict[key];
            }

            //if the max is less than 2 return it right away to indicate an error.
            if (max < 2)
                return max;

            SortedSet<double> keys = new SortedSet<double>(dict.Keys);
            foreach (double key in keys)
                if (dict[key] == max)
                    mode = key;
            return mode;

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
