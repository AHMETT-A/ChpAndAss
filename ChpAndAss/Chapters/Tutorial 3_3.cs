using System;
using System.Windows.Forms;

namespace ChpAndAss.Chapters
{
    public partial class Tutorial_3_3 : Form
    {
        public Tutorial_3_3()
        {
            InitializeComponent();
        }

        private void Calbtn_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(OriginaltextBox.Text, out decimal originalPrice))
            {
                MessageBox.Show("Please enter a valid number for Original Price.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                OriginaltextBox.Focus();
                return;
            }

            if (!decimal.TryParse(discountPercentagetextBox.Text, out decimal discountPercentage))
            {
                MessageBox.Show("Please enter a valid number for Discount Percentage.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                discountPercentagetextBox.Focus();
                return;
            }

            if (discountPercentage < 0 || discountPercentage > 100)
            {
                MessageBox.Show("Discount percentage must be between 0 and 100.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                discountPercentagetextBox.Focus();
                return;
            }

            decimal discountAmount = originalPrice * (discountPercentage / 100);
            decimal salePrice = originalPrice - discountAmount;

            salePricelabel.Text = "Sale Price: " + salePrice.ToString("C");
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
