namespace ChpAndAss.Assigments
{
    partial class A1
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
            Englishbtn = new Button();
            Itaaliabtn = new Button();
            spanbtn = new Button();
            label1 = new Label();
            translationLabel = new Label();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // Englishbtn
            // 
            Englishbtn.BackColor = Color.LightSkyBlue;
            Englishbtn.Font = new Font("Nirmala UI", 12F);
            Englishbtn.Location = new Point(113, 263);
            Englishbtn.Name = "Englishbtn";
            Englishbtn.Size = new Size(140, 63);
            Englishbtn.TabIndex = 0;
            Englishbtn.Text = "English";
            Englishbtn.UseVisualStyleBackColor = false;
            Englishbtn.Click += Englishbtn_Click;
            // 
            // Itaaliabtn
            // 
            Itaaliabtn.BackColor = Color.LightSkyBlue;
            Itaaliabtn.Font = new Font("Nirmala UI", 12F);
            Itaaliabtn.Location = new Point(317, 263);
            Itaaliabtn.Name = "Itaaliabtn";
            Itaaliabtn.Size = new Size(141, 63);
            Itaaliabtn.TabIndex = 1;
            Itaaliabtn.Text = " Italian ";
            Itaaliabtn.UseVisualStyleBackColor = false;
            Itaaliabtn.Click += Itaaliabtn_Click;
            // 
            // spanbtn
            // 
            spanbtn.BackColor = Color.LightSkyBlue;
            spanbtn.Font = new Font("Nirmala UI", 12F);
            spanbtn.Location = new Point(540, 263);
            spanbtn.Name = "spanbtn";
            spanbtn.Size = new Size(148, 63);
            spanbtn.TabIndex = 2;
            spanbtn.Text = " Spanish";
            spanbtn.UseVisualStyleBackColor = false;
            spanbtn.Click += spanbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Wheat;
            label1.Font = new Font("Cambria", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 35);
            label1.Name = "label1";
            label1.Size = new Size(385, 33);
            label1.TabIndex = 3;
            label1.Text = "Select a language and I will say";
            // 
            // translationLabel
            // 
            translationLabel.BackColor = Color.PaleGreen;
            translationLabel.BorderStyle = BorderStyle.FixedSingle;
            translationLabel.Font = new Font("Cambria", 14F);
            translationLabel.Location = new Point(187, 126);
            translationLabel.Name = "translationLabel";
            translationLabel.Size = new Size(407, 38);
            translationLabel.TabIndex = 4;
            translationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.Location = new Point(187, 422);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 5;
            BackMenubtn.Text = "Back Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 542);
            Controls.Add(BackMenubtn);
            Controls.Add(translationLabel);
            Controls.Add(label1);
            Controls.Add(spanbtn);
            Controls.Add(Itaaliabtn);
            Controls.Add(Englishbtn);
            Name = "A1";
            Text = "A1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Englishbtn;
        private Button Itaaliabtn;
        private Button spanbtn;
        private Label label1;
        private Label translationLabel;
        private Button BackMenubtn;
    }
}