using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChpAndAss.Chapters
{
    public partial class T_1 : Form
    {
        public T_1()
        {
            InitializeComponent();
        }

        private void Calbtn_Click(object sender, EventArgs e)
        {
            double hoursWorked;
            double hourlyRate;

            // Check if input is valid number
            if (double.TryParse(txtHours.Text, out hoursWorked) && double.TryParse(txtRate.Text, out hourlyRate))
            {
                double grossPay = hoursWorked * hourlyRate;
                MessageBox.Show("Your Gross Pay is: $" + grossPay.ToString("0.00"), "Result");
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for both fields.", "Error");
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
