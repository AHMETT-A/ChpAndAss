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
    public partial class A_18 : Form
    {
        public A_18()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int cookiesEaten;

            if (int.TryParse(txtCookies.Text, out cookiesEaten))
            {
                int caloriesPerCookie = 75;

                int totalCalories = cookiesEaten * caloriesPerCookie;

                lblResult.Text = "Total calories consumed: " + totalCalories.ToString("N0");
            }
            else
            {
                MessageBox.Show("Please enter a valid number of cookies.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
