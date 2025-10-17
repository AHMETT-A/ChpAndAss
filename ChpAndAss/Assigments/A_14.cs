using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChpAndAss.Assigments
{
    public partial class A_14 : Form
    {
        public A_14()
        {
            InitializeComponent();
        }

        private void btnToFahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                double celsius = double.Parse(txtTemp.Text);
                double fahrenheit = (celsius * 9 / 5) + 32;
                lblResult.Text = $"{celsius}°C = {fahrenheit:0.00}°F";
            }
            catch
            {
                MessageBox.Show("Please enter a valid numeric temperature.");
            }
        }

        private void btnToCelsius_Click(object sender, EventArgs e)
        {
            try
            {
                double fahrenheit = double.Parse(txtTemp.Text);
                double celsius = (fahrenheit - 32) * 5 / 9;
                lblResult.Text = $"{fahrenheit}°F = {celsius:0.00}°C";
            }
            catch
            {
                MessageBox.Show("Please enter a valid numeric temperature.");
            }
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
