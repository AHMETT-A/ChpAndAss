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
    public partial class A_3 : Form
    {
        public A_3()
        {
            InitializeComponent();
        }

        private void Qadarpicture_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Qadar";
        }

        private void Yamanpicture_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Yaman";

        }

        private void Somalipicture_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Somalia";

        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
