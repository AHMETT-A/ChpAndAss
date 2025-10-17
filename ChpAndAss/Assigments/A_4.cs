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
    public partial class A_4 : Form
    {
        public A_4()
        {
            InitializeComponent();
        }

        private void Cardbackbtn_Click(object sender, EventArgs e)
        {
            Cardbackpicture.Visible = true;
            cardFacePictureBox.Visible = false;
        }

        private void CardFacebtn_Click(object sender, EventArgs e)
        {
            Cardbackpicture.Visible = false;
            cardFacePictureBox.Visible = true;
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
