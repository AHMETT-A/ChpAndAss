namespace ChpAndAss.Assigments
{
    partial class A_2
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
            CatPicture = new PictureBox();
            BackMenubtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CatPicture).BeginInit();
            SuspendLayout();
            // 
            // CatPicture
            // 
            CatPicture.Image = Properties.Resources.Bisad;
            CatPicture.Location = new Point(241, 63);
            CatPicture.Name = "CatPicture";
            CatPicture.Size = new Size(305, 339);
            CatPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            CatPicture.TabIndex = 0;
            CatPicture.TabStop = false;
            CatPicture.Click += CatPicture_Click;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.Location = new Point(198, 472);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 6;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 584);
            Controls.Add(BackMenubtn);
            Controls.Add(CatPicture);
            Name = "A_2";
            Text = "A_2";
            ((System.ComponentModel.ISupportInitialize)CatPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CatPicture;
        private Button BackMenubtn;
    }
}