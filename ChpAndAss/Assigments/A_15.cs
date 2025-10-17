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
    public partial class A_15 : Form
    {
        public A_15()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = double.Parse(txtWeight.Text);
                double height = double.Parse(txtHeight.Text);

                double bmi = (weight * 703) / (height * height);

                lblResult.Text = $"Your BMI is: {bmi:0.00}";

                if (bmi < 18.5)
                    lblResult.Text += " (Underweight)";
                else if (bmi < 25)
                    lblResult.Text += " (Normal weight)";
                else if (bmi < 30)
                    lblResult.Text += " (Overweight)";
                else
                    lblResult.Text += " (Obese)";
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values for weight and height.");
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
