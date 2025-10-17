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
    public partial class A_19 : Form
    {
        public A_19()
        {
            InitializeComponent();
        }
        private int totalCalories = 0;

        private void A_15_CalorieCounter_Load(object sender, EventArgs e)
        {
            lblTotalCalories.Text = "0";
        }
        private void picBanana_Click(object sender, EventArgs e)
        {
            AddCalories(115);
        }

        private void picApple_Click(object sender, EventArgs e)
        {
            AddCalories(80);
        }

        private void picOrange_Click(object sender, EventArgs e)
        {
            AddCalories(90);
        }

        private void picPear_Click(object sender, EventArgs e)
        {
            AddCalories(120);
        }
        private void AddCalories(int calories)
        {
            totalCalories += calories;
            lblTotalCalories.Text = totalCalories.ToString();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            totalCalories = 0;
            lblTotalCalories.Text = "0";
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
