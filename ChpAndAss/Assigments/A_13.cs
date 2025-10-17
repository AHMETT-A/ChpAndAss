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
    public partial class A_13 : Form
    {
        public A_13()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal purchaseAmount = decimal.Parse(txtPurchase.Text);
                decimal stateTaxRate = 0.04m;
                decimal countyTaxRate = 0.02m;
                decimal stateTax = purchaseAmount * stateTaxRate;
                decimal countyTax = purchaseAmount * countyTaxRate;
                decimal totalTax = stateTax + countyTax;
                decimal totalSale = purchaseAmount + totalTax;

                lblStateTax.Text = "State Tax: $" + stateTax.ToString("0.00");
                lblCountyTax.Text = "County Tax: $" + countyTax.ToString("0.00");
                lblTotalTax.Text = "Total Tax: $" + totalTax.ToString("0.00");
                lblTotalSale.Text = "Total Sale: $" + totalSale.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Please enter a valid purchase amount.");
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
