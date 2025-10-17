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
    public partial class T_3_6 : Form
    {
        public T_3_6()
        {
            InitializeComponent();
        }

        private void Showbtn_Click(object sender, EventArgs e)
        {
            string fullName;
            fullName = FirsttextBox.Text = LasttextBox.Text;
            Fullnamelabel.Text = fullName;

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
