namespace ChpAndAss.Assigments
{
    partial class A_3
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
            label1 = new Label();
            countryLabel = new Label();
            Qadarpicture = new PictureBox();
            Yamanpicture = new PictureBox();
            Somalipicture = new PictureBox();
            BackMenubtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Qadarpicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Yamanpicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Somalipicture).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 31);
            label1.Name = "label1";
            label1.Size = new Size(524, 45);
            label1.TabIndex = 0;
            label1.Text = " Click a flag to see the name of the ";
            // 
            // countryLabel
            // 
            countryLabel.BorderStyle = BorderStyle.FixedSingle;
            countryLabel.Font = new Font("Cambria", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countryLabel.ForeColor = SystemColors.ButtonHighlight;
            countryLabel.Location = new Point(340, 359);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(471, 38);
            countryLabel.TabIndex = 1;
            countryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Qadarpicture
            // 
            Qadarpicture.Image = Properties.Resources.Qadar;
            Qadarpicture.Location = new Point(96, 130);
            Qadarpicture.Name = "Qadarpicture";
            Qadarpicture.Size = new Size(283, 172);
            Qadarpicture.SizeMode = PictureBoxSizeMode.StretchImage;
            Qadarpicture.TabIndex = 2;
            Qadarpicture.TabStop = false;
            Qadarpicture.Click += Qadarpicture_Click;
            // 
            // Yamanpicture
            // 
            Yamanpicture.Image = Properties.Resources.Yaman;
            Yamanpicture.Location = new Point(422, 130);
            Yamanpicture.Name = "Yamanpicture";
            Yamanpicture.Size = new Size(294, 172);
            Yamanpicture.SizeMode = PictureBoxSizeMode.StretchImage;
            Yamanpicture.TabIndex = 3;
            Yamanpicture.TabStop = false;
            Yamanpicture.Click += Yamanpicture_Click;
            // 
            // Somalipicture
            // 
            Somalipicture.Image = Properties.Resources.Somali;
            Somalipicture.Location = new Point(801, 130);
            Somalipicture.Name = "Somalipicture";
            Somalipicture.Size = new Size(274, 172);
            Somalipicture.SizeMode = PictureBoxSizeMode.StretchImage;
            Somalipicture.TabIndex = 4;
            Somalipicture.TabStop = false;
            Somalipicture.Click += Somalipicture_Click;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.Location = new Point(365, 506);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 7;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1120, 657);
            Controls.Add(BackMenubtn);
            Controls.Add(Somalipicture);
            Controls.Add(Yamanpicture);
            Controls.Add(Qadarpicture);
            Controls.Add(countryLabel);
            Controls.Add(label1);
            Name = "A_3";
            Text = "A_3";
            ((System.ComponentModel.ISupportInitialize)Qadarpicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)Yamanpicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)Somalipicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label countryLabel;
        private PictureBox Qadarpicture;
        private PictureBox Yamanpicture;
        private PictureBox Somalipicture;
        private Button BackMenubtn;
    }
}