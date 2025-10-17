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
    public partial class A_8 : Form
    {
        public A_8()
        {
            InitializeComponent();
        }

        private void btnShowHeads_Click(object sender, EventArgs e)
        {
            pictureBoxTwoImgs.Image = Properties.Resources.Head;
        }

        private void btnShowTails_Click(object sender, EventArgs e)
        {
            pictureBoxTwoImgs.Image = Properties.Resources.Tail;
        }


        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
