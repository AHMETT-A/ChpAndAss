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
    public partial class A_23 : Form
    {
        public A_23()
        {
            InitializeComponent();
        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const double CLASS_A_PRICE = 15.0;
            const double CLASS_B_PRICE = 12.0;
            const double CLASS_C_PRICE = 9.0;

            int classA, classB, classC;

            if (int.TryParse(txtClassA.Text, out classA) &&
                int.TryParse(txtClassB.Text, out classB) &&
                int.TryParse(txtClassC.Text, out classC))
            {
                double revenueA = classA * CLASS_A_PRICE;
                double revenueB = classB * CLASS_B_PRICE;
                double revenueC = classC * CLASS_C_PRICE;
                double totalRevenue = revenueA + revenueB + revenueC;

                lblClassARevenue.Text = revenueA.ToString("C2");
                lblClassBRevenue.Text = revenueB.ToString("C2");
                lblClassCRevenue.Text = revenueC.ToString("C2");
                lblTotalRevenue.Text = totalRevenue.ToString("C2");
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for all ticket sales.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassA.Clear();
            txtClassB.Clear();
            txtClassC.Clear();
            lblClassARevenue.Text = "";
            lblClassBRevenue.Text = "";
            lblClassCRevenue.Text = "";
            lblTotalRevenue.Text = "";
            txtClassA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
