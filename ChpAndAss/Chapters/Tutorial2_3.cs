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
    public partial class Tutorial2_3 : Form
    {
        public Tutorial2_3()
        {
            InitializeComponent();
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {

            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void Firstbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First Button");
        }

        private void Secondbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Second Button");
        }

        private void Lastbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Last Button");
        }
    }
}
