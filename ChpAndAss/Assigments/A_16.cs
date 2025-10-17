using System;
using System.Windows.Forms;

namespace ChpAndAss.Assigments
{
    public partial class A_16 : Form
    {
        public A_16()
        {
            InitializeComponent();
        }

        // Word / punctuation buttons
        private void btnWord_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string word = btn.Text;

            if (word == "." || word == "!" || word == ",")
                lblSentence.Text += word;
            else
                lblSentence.Text += (lblSentence.Text.Length == 0 ? "" : " ") + word;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblSentence.Text = "";
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            lblSentence.Text = "";
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
