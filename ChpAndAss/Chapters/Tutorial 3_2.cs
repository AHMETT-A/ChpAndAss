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
    public partial class Tutorial_3_2 : Form
    {
        public Tutorial_3_2()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles;
            double gallons;
            double mpg;


            miles = double.Parse(MilestextBox.Text);
            gallons = double.Parse(GallonstextBox.Text);
            mpg = miles / gallons;
            Mpglabel.Text = mpg.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
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
