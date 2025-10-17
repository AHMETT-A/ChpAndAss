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
    public partial class A_11 : Form
    {
        public A_11()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal foodCharge = decimal.Parse(txtFoodCharge.Text);

                decimal tip = foodCharge * 0.15m;
                decimal tax = foodCharge * 0.07m;

                decimal total = foodCharge + tip + tax;

                lblTip.Text = "Tip: $" + tip.ToString("0.00");
                lblTax.Text = "Tax: $" + tax.ToString("0.00");
                lblTotal.Text = "Total: $" + total.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Please enter a valid number for the food charge.");
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
