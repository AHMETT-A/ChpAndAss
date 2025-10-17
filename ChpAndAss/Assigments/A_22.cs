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
    public partial class A_22 : Form
    {
        public A_22()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double propertyValue;

            if (double.TryParse(txtPropertyValue.Text, out propertyValue))
            {
                const double TAX_RATE = 0.64;

                double propertyTax = (propertyValue / 100) * TAX_RATE;

                lblResult.Text = "Property Tax: $" + propertyTax.ToString("N2");
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric property value.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
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
