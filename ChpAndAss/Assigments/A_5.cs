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
    public partial class A_5 : Form
    {
        public A_5()
        {
            InitializeComponent();
        }

        private void btnSinister_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Left";
        }

        private void btnDexter_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Right";
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Center";
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {

            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
