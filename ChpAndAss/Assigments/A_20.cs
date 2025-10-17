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
    public partial class A_20 : Form
    {
        public A_20()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal loan, insurance, gas, oil, tires, maintenance;

            if (decimal.TryParse(txtLoan.Text, out loan) &&
                decimal.TryParse(txtInsurance.Text, out insurance) &&
                decimal.TryParse(txtGas.Text, out gas) &&
                decimal.TryParse(txtOil.Text, out oil) &&
                decimal.TryParse(txtTires.Text, out tires) &&
                decimal.TryParse(txtMaintenance.Text, out maintenance))
            {
                decimal monthlyTotal = loan + insurance + gas + oil + tires + maintenance;

                decimal annualTotal = monthlyTotal * 12;

                lblMonthlyTotal.Text = "Total Monthly Cost: $" + monthlyTotal.ToString("N2");
                lblAnnualTotal.Text = "Total Annual Cost: $" + annualTotal.ToString("N2");
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for all expenses.",
                                "Invalid Input",
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
