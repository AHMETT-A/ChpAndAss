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
    public partial class A_10 : Form
    {
        public A_10()
        {
            InitializeComponent();
        }

        private void btnFormat1_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{txtTitle.Text} {txtFirst.Text} {txtMiddle.Text} {txtLast.Text}";
        }

        private void btnFormat2_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{txtFirst.Text} {txtMiddle.Text} {txtLast.Text}";
        }

        private void btnFormat3_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{txtFirst.Text} {txtLast.Text}";
        }

        private void btnFormat4_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{txtLast.Text}, {txtFirst.Text} {txtMiddle.Text}, {txtTitle.Text}";
        }

        private void btnFormat5_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{txtLast.Text}, {txtFirst.Text} {txtMiddle.Text}";
        }

        private void btnFormat6_Click(object sender, EventArgs e)
        {
            lblResult.Text = $"{txtLast.Text}, {txtFirst.Text}";
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
