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
    public partial class A_6 : Form
    {
        public A_6()
        {
            InitializeComponent();
        }

        private void picOne_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One");
        }

        private void picTwo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two");
        }

        private void picThree_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three");
        }

        private void picFour_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four");
        }

        private void picFive_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five");
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
