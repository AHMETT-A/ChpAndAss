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
    public partial class Tutorial_3_4 : Form
    {
        public Tutorial_3_4()
        {
            InitializeComponent();
        }

        private void Calbtn_Click(object sender, EventArgs e)
        {
            try
            {
                double test1;
                double test2;
                double test3;
                double average;


                test1 = double.Parse(test1textBox.Text);
                test2 = double.Parse(test2textBox.Text);
                test3 = double.Parse(test3textBox.Text);


                average = (test1 + test2 + test3) / 3.0;

                Avaregalabal.Text = average.ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            test1textBox.Text = "";
            test2textBox.Text = "";
            test3textBox.Text = "";
            Avaregalabal.Text = "";
        }

        private void exitbtn_Click(object sender, EventArgs e)
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
