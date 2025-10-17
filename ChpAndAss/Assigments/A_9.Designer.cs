namespace ChpAndAss.Assigments
{
    partial class A_9
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
            pictureBox = new PictureBox();
            Showstartbutton = new Button();
            Hidestartbutton = new Button();
            labelBetelgeuse = new Label();
            labelMeissa = new Label();
            labelAlnitak = new Label();
            labelAlnilan = new Label();
            labelMintaka = new Label();
            labelSaiph = new Label();
            labelRigel = new Label();
            Exitbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.Orion;
            pictureBox.Location = new Point(108, 60);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(755, 481);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // Showstartbutton
            // 
            Showstartbutton.BackColor = Color.DarkOrange;
            Showstartbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Showstartbutton.Location = new Point(149, 598);
            Showstartbutton.Name = "Showstartbutton";
            Showstartbutton.Size = new Size(219, 80);
            Showstartbutton.TabIndex = 1;
            Showstartbutton.Text = "Show Start";
            Showstartbutton.UseVisualStyleBackColor = false;
            Showstartbutton.Click += Showstartbutton_Click;
            // 
            // Hidestartbutton
            // 
            Hidestartbutton.BackColor = Color.DarkOrange;
            Hidestartbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Hidestartbutton.Location = new Point(427, 598);
            Hidestartbutton.Name = "Hidestartbutton";
            Hidestartbutton.Size = new Size(210, 80);
            Hidestartbutton.TabIndex = 2;
            Hidestartbutton.Text = "Show Hide";
            Hidestartbutton.UseVisualStyleBackColor = false;
            Hidestartbutton.Click += Hidestartbutton_Click;
            // 
            // labelBetelgeuse
            // 
            labelBetelgeuse.AutoSize = true;
            labelBetelgeuse.Location = new Point(191, 72);
            labelBetelgeuse.Name = "labelBetelgeuse";
            labelBetelgeuse.Size = new Size(97, 25);
            labelBetelgeuse.TabIndex = 3;
            labelBetelgeuse.Text = "Betelgeuse";
            // 
            // labelMeissa
            // 
            labelMeissa.AutoSize = true;
            labelMeissa.Location = new Point(260, 294);
            labelMeissa.Name = "labelMeissa";
            labelMeissa.Size = new Size(66, 25);
            labelMeissa.TabIndex = 4;
            labelMeissa.Text = "Meissa";
            // 
            // labelAlnitak
            // 
            labelAlnitak.AutoSize = true;
            labelAlnitak.Location = new Point(191, 438);
            labelAlnitak.Name = "labelAlnitak";
            labelAlnitak.Size = new Size(66, 25);
            labelAlnitak.TabIndex = 5;
            labelAlnitak.Text = "Alnitak";
            // 
            // labelAlnilan
            // 
            labelAlnilan.AutoSize = true;
            labelAlnilan.Location = new Point(420, 313);
            labelAlnilan.Name = "labelAlnilan";
            labelAlnilan.Size = new Size(65, 25);
            labelAlnilan.TabIndex = 6;
            labelAlnilan.Text = "Alnilan";
            // 
            // labelMintaka
            // 
            labelMintaka.AutoSize = true;
            labelMintaka.Location = new Point(562, 258);
            labelMintaka.Name = "labelMintaka";
            labelMintaka.Size = new Size(75, 25);
            labelMintaka.TabIndex = 7;
            labelMintaka.Text = "Mintaka";
            // 
            // labelSaiph
            // 
            labelSaiph.AutoSize = true;
            labelSaiph.Location = new Point(675, 131);
            labelSaiph.Name = "labelSaiph";
            labelSaiph.Size = new Size(56, 25);
            labelSaiph.TabIndex = 8;
            labelSaiph.Text = "Saiph";
            // 
            // labelRigel
            // 
            labelRigel.AutoSize = true;
            labelRigel.Location = new Point(662, 416);
            labelRigel.Name = "labelRigel";
            labelRigel.Size = new Size(51, 25);
            labelRigel.TabIndex = 9;
            labelRigel.Text = "Rigel";
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = Color.SaddleBrown;
            Exitbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Exitbtn.ForeColor = SystemColors.ButtonFace;
            Exitbtn.Location = new Point(695, 598);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(210, 80);
            Exitbtn.TabIndex = 10;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = false;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // A_9
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1058, 751);
            Controls.Add(Exitbtn);
            Controls.Add(labelRigel);
            Controls.Add(labelSaiph);
            Controls.Add(labelMintaka);
            Controls.Add(labelAlnilan);
            Controls.Add(labelAlnitak);
            Controls.Add(labelMeissa);
            Controls.Add(labelBetelgeuse);
            Controls.Add(Hidestartbutton);
            Controls.Add(Showstartbutton);
            Controls.Add(pictureBox);
            Name = "A_9";
            Text = "A_9";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button Showstartbutton;
        private Button Hidestartbutton;
        private Label labelBetelgeuse;
        private Label labelMeissa;
        private Label labelAlnitak;
        private Label labelAlnilan;
        private Label labelMintaka;
        private Label labelSaiph;
        private Label labelRigel;
        private Button Exitbtn;
    }
}