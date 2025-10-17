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
    public partial class A_12 : Form
    {
        public A_12()
        {
            InitializeComponent();
        }

        private void btn5Hours_Click(object sender, EventArgs e)
        {
            CalculateDistance(5);
        }

        private void btn8Hours_Click(object sender, EventArgs e)
        {
            CalculateDistance(8);
        }

        private void btn12Hours_Click(object sender, EventArgs e)
        {
            CalculateDistance(12);
        }

        private void CalculateDistance(int hours)
        {
            try
            {
                double speed = double.Parse(txtSpeed.Text);
                double distance = speed * hours;
                lblResult.Text = $"In {hours} hours, the car will travel {distance} miles.";
            }
            catch
            {
                MessageBox.Show("Please enter a valid number for speed.");
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
