namespace ChpAndAss.Chapters
{
    partial class T_3_2
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
            ReadInputbtn = new Button();
            Exitbtn = new Button();
            NametextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Outputlabel = new Label();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // ReadInputbtn
            // 
            ReadInputbtn.BackColor = Color.Chartreuse;
            ReadInputbtn.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            ReadInputbtn.Location = new Point(134, 289);
            ReadInputbtn.Name = "ReadInputbtn";
            ReadInputbtn.Size = new Size(267, 82);
            ReadInputbtn.TabIndex = 0;
            ReadInputbtn.Text = "Read Input";
            ReadInputbtn.UseVisualStyleBackColor = false;
            ReadInputbtn.Click += ReadInputbtn_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = Color.Chartreuse;
            Exitbtn.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            Exitbtn.Location = new Point(458, 289);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(267, 82);
            Exitbtn.TabIndex = 1;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = false;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(424, 99);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(232, 31);
            NametextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 99);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 4;
            label1.Text = "Enter Your Name  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 183);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 5;
            label2.Text = "You Entered  :";
            // 
            // Outputlabel
            // 
            Outputlabel.BorderStyle = BorderStyle.FixedSingle;
            Outputlabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Outputlabel.Location = new Point(424, 182);
            Outputlabel.Name = "Outputlabel";
            Outputlabel.Size = new Size(232, 38);
            Outputlabel.TabIndex = 6;
            Outputlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(243, 482);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 8;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // T_3_2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(800, 604);
            Controls.Add(BackMenubtn);
            Controls.Add(Outputlabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NametextBox);
            Controls.Add(Exitbtn);
            Controls.Add(ReadInputbtn);
            Name = "T_3_2";
            Text = "T_3_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReadInputbtn;
        private Button Exitbtn;
        private TextBox NametextBox;
        private Label label1;
        private Label label2;
        private Label Outputlabel;
        private Button BackMenubtn;
    }
}