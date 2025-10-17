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
    public partial class A_17 : Form
    {
        public A_17()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal replacementCost;

            if (decimal.TryParse(txtReplacementCost.Text, out replacementCost))
            {
                decimal minInsurance = replacementCost * 0.8m;

                lblResult.Text = "Minimum insurance required: $" + minInsurance.ToString("N2");
            }
            else
            {
                MessageBox.Show("Please enter a valid number for replacement cost.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
