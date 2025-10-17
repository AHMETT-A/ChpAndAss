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
    public partial class A_7 : Form
    {
        public A_7()
        {
            InitializeComponent();
        }

        private void JokerpictureBox_Click(object sender, EventArgs e)
        {
            Cardslabel.Text = "Joker";
        }

        private void Card10pictureBox_Click(object sender, EventArgs e)
        {
            Cardslabel.Text = "Card !0";
        }

        private void Card2pictureBox_Click(object sender, EventArgs e)
        {
            Cardslabel.Text = "Card 2";
        }

        private void CardqpictureBox_Click(object sender, EventArgs e)
        {
            Cardslabel.Text = "Card Q";
        }

        private void Card9pictureBox_Click(object sender, EventArgs e)
        {
            Cardslabel.Text = "Card 9";
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
