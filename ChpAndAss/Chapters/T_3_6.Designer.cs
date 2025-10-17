namespace ChpAndAss.Chapters
{
    partial class T_3_6
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
            Showbtn = new Button();
            Exitbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Fullnamelabel = new Label();
            FirsttextBox = new TextBox();
            LasttextBox = new TextBox();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // Showbtn
            // 
            Showbtn.BackColor = Color.GreenYellow;
            Showbtn.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            Showbtn.Location = new Point(319, 308);
            Showbtn.Name = "Showbtn";
            Showbtn.Size = new Size(182, 73);
            Showbtn.TabIndex = 0;
            Showbtn.Text = "Show Name";
            Showbtn.UseVisualStyleBackColor = false;
            Showbtn.Click += Showbtn_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = Color.GreenYellow;
            Exitbtn.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            Exitbtn.Location = new Point(528, 308);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(182, 73);
            Exitbtn.TabIndex = 1;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = false;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label1.Location = new Point(156, 61);
            label1.Name = "label1";
            label1.Size = new Size(235, 30);
            label1.TabIndex = 2;
            label1.Text = "Enter Your First Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label2.Location = new Point(143, 131);
            label2.Name = "label2";
            label2.Size = new Size(232, 30);
            label2.TabIndex = 3;
            label2.Text = "Enter Your Last Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label3.Location = new Point(156, 204);
            label3.Name = "label3";
            label3.Size = new Size(211, 30);
            label3.TabIndex = 4;
            label3.Text = "This You Full Name :";
            // 
            // Fullnamelabel
            // 
            Fullnamelabel.BorderStyle = BorderStyle.FixedSingle;
            Fullnamelabel.Location = new Point(411, 201);
            Fullnamelabel.Name = "Fullnamelabel";
            Fullnamelabel.Size = new Size(250, 38);
            Fullnamelabel.TabIndex = 5;
            Fullnamelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FirsttextBox
            // 
            FirsttextBox.Location = new Point(411, 62);
            FirsttextBox.Name = "FirsttextBox";
            FirsttextBox.Size = new Size(250, 31);
            FirsttextBox.TabIndex = 6;
            // 
            // LasttextBox
            // 
            LasttextBox.Location = new Point(411, 129);
            LasttextBox.Name = "LasttextBox";
            LasttextBox.Size = new Size(250, 31);
            LasttextBox.TabIndex = 7;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(319, 475);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 9;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // T_3_6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(994, 628);
            Controls.Add(BackMenubtn);
            Controls.Add(LasttextBox);
            Controls.Add(FirsttextBox);
            Controls.Add(Fullnamelabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Exitbtn);
            Controls.Add(Showbtn);
            Name = "T_3_6";
            Text = "T_3_6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Showbtn;
        private Button Exitbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Fullnamelabel;
        private TextBox FirsttextBox;
        private TextBox LasttextBox;
        private Button BackMenubtn;
    }
}