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
    public partial class A_21 : Form
    {
        public A_21()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double squareFeet, pricePerGallon;

            if (double.TryParse(txtSquareFeet.Text, out squareFeet) &&
                double.TryParse(txtPricePerGallon.Text, out pricePerGallon))
            {
                const double COVERAGE_PER_GALLON = 115.0;
                const double HOURS_PER_GALLON = 8.0;
                const double LABOR_RATE = 20.0;

                double gallonsRequired = Math.Ceiling(squareFeet / COVERAGE_PER_GALLON); // round up
                double laborHours = gallonsRequired * HOURS_PER_GALLON;
                double paintCost = gallonsRequired * pricePerGallon;
                double laborCharges = laborHours * LABOR_RATE;
                double totalCost = paintCost + laborCharges;

                lblGallons.Text = "Gallons of Paint Required: " + gallonsRequired.ToString("N0");
                lblLabor.Text = "Hours of Labor Required: " + laborHours.ToString("N2");
                lblPaintCost.Text = "Cost of Paint: $" + paintCost.ToString("N2");
                lblLaborCost.Text = "Labor Charges: $" + laborCharges.ToString("N2");
                lblTotalCost.Text = "Total Cost of the Paint Job: $" + totalCost.ToString("N2");
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for both inputs.",
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
