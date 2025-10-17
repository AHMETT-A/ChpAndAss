using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChpAndAss
{
    public partial class Ahmet_T : Form
    {
        public Ahmet_T()
        {
            InitializeComponent();
        }

        private void btnSaveSticker_Click(object sender, EventArgs e)
        {
            try
            {
                using (Bitmap bmp = new Bitmap(stickerPanel.Width, stickerPanel.Height))
                {
                    stickerPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

                    string path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                        "Sticker_777.png"
                    );

                    bmp.Save(path, System.Drawing.Imaging.ImageFormat.Png);

                    MessageBox.Show($"Sticker saved successfully!\n\nPath:\n{path}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving sticker:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
