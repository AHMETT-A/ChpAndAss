namespace ChpAndAss.Chapters
{
    partial class Tutorial_3_3
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
            Calbtn = new Button();
            Exitbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            salePricelabel = new Label();
            OriginaltextBox = new TextBox();
            discountPercentagetextBox = new TextBox();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // Calbtn
            // 
            Calbtn.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            Calbtn.Location = new Point(252, 436);
            Calbtn.Name = "Calbtn";
            Calbtn.Size = new Size(178, 82);
            Calbtn.TabIndex = 0;
            Calbtn.Text = " Calculate Sale Price ";
            Calbtn.UseVisualStyleBackColor = true;
            Calbtn.Click += Calbtn_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            Exitbtn.Location = new Point(556, 436);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(178, 82);
            Exitbtn.TabIndex = 1;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = true;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(106, 62);
            label1.Name = "label1";
            label1.Size = new Size(324, 30);
            label1.TabIndex = 2;
            label1.Text = " Enter the item’s original price: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(106, 167);
            label2.Name = "label2";
            label2.Size = new Size(324, 30);
            label2.TabIndex = 3;
            label2.Text = " Enter the discount percentage:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(252, 267);
            label3.Name = "label3";
            label3.Size = new Size(126, 30);
            label3.TabIndex = 4;
            label3.Text = " Sale price: ";
            // 
            // salePricelabel
            // 
            salePricelabel.BorderStyle = BorderStyle.FixedSingle;
            salePricelabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            salePricelabel.ForeColor = SystemColors.Window;
            salePricelabel.Location = new Point(483, 259);
            salePricelabel.Name = "salePricelabel";
            salePricelabel.Size = new Size(311, 38);
            salePricelabel.TabIndex = 5;
            salePricelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OriginaltextBox
            // 
            OriginaltextBox.Location = new Point(483, 63);
            OriginaltextBox.Name = "OriginaltextBox";
            OriginaltextBox.Size = new Size(315, 31);
            OriginaltextBox.TabIndex = 6;
            // 
            // discountPercentagetextBox
            // 
            discountPercentagetextBox.Location = new Point(479, 166);
            discountPercentagetextBox.Name = "discountPercentagetextBox";
            discountPercentagetextBox.Size = new Size(315, 31);
            discountPercentagetextBox.TabIndex = 7;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(304, 589);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 14;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // Tutorial_3_3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(942, 729);
            Controls.Add(BackMenubtn);
            Controls.Add(discountPercentagetextBox);
            Controls.Add(OriginaltextBox);
            Controls.Add(salePricelabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Exitbtn);
            Controls.Add(Calbtn);
            Name = "Tutorial_3_3";
            Text = "Tutorial_3_3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calbtn;
        private Button Exitbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label salePricelabel;
        private TextBox OriginaltextBox;
        private TextBox discountPercentagetextBox;
        private Button BackMenubtn;
    }
}