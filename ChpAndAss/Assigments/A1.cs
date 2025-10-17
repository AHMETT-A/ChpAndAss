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
    public partial class A1 : Form
    {
        public A1()
        {
            InitializeComponent();
        }



        private void Englishbtn_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Good Morring";
        }

        private void Itaaliabtn_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buenos Dias";
        }

        private void spanbtn_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Guten Morgen";
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
