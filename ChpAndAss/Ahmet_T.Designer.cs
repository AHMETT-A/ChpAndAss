namespace ChpAndAss
{
    partial class Ahmet_T
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stickerPanel = new Panel();
            lblId = new Label();
            lblName = new Label();
            pictureBoxPhoto = new PictureBox();
            btnSaveSticker = new Button();
            BackMenubtn = new Button();
            stickerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // stickerPanel
            // 
            stickerPanel.BorderStyle = BorderStyle.FixedSingle;
            stickerPanel.Controls.Add(lblId);
            stickerPanel.Controls.Add(lblName);
            stickerPanel.Controls.Add(pictureBoxPhoto);
            stickerPanel.Location = new Point(554, 57);
            stickerPanel.Name = "stickerPanel";
            stickerPanel.Size = new Size(633, 538);
            stickerPanel.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lblId.Location = new Point(266, 453);
            lblId.Name = "lblId";
            lblId.Size = new Size(88, 32);
            lblId.TabIndex = 2;
            lblId.Text = "ID: 777";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lblName.Location = new Point(193, 378);
            lblName.Name = "lblName";
            lblName.Size = new Size(267, 38);
            lblName.TabIndex = 1;
            lblName.Text = "Ahmet Abdikadir Yusuf";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Image = Properties.Resources.Ahmet;
            pictureBoxPhoto.Location = new Point(193, 41);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(265, 302);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto.TabIndex = 0;
            pictureBoxPhoto.TabStop = false;
            // 
            // btnSaveSticker
            // 
            btnSaveSticker.BackColor = Color.MistyRose;
            btnSaveSticker.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSaveSticker.Location = new Point(708, 638);
            btnSaveSticker.Name = "btnSaveSticker";
            btnSaveSticker.Size = new Size(307, 103);
            btnSaveSticker.TabIndex = 3;
            btnSaveSticker.Text = "Save Sticker";
            btnSaveSticker.UseVisualStyleBackColor = false;
            btnSaveSticker.Click += btnSaveSticker_Click;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(694, 803);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(338, 91);
            BackMenubtn.TabIndex = 19;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // Ahmet_T
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1678, 919);
            Controls.Add(BackMenubtn);
            Controls.Add(btnSaveSticker);
            Controls.Add(stickerPanel);
            Name = "Ahmet_T";
            Text = "Ahmet_T";
            WindowState = FormWindowState.Maximized;
            stickerPanel.ResumeLayout(false);
            stickerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel stickerPanel;
        private Button btnSaveSticker;
        private Label lblId;
        private Label lblName;
        private PictureBox pictureBoxPhoto;
        private Button BackMenubtn;
    }
}