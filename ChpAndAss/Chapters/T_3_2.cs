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
    public partial class T_3_2 : Form
    {
        public T_3_2()
        {
            InitializeComponent();
        }

        private void ReadInputbtn_Click(object sender, EventArgs e)
        {
            Outputlabel.Text = NametextBox.Text;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
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
