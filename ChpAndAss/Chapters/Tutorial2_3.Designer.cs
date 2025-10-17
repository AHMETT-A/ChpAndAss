namespace ChpAndAss.Chapters
{
    partial class Tutorial2_3
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
            Firstbutton = new Button();
            Secondbutton = new Button();
            Lastbutton = new Button();
            label1 = new Label();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // Firstbutton
            // 
            Firstbutton.BackColor = Color.IndianRed;
            Firstbutton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Firstbutton.ForeColor = SystemColors.ButtonFace;
            Firstbutton.Location = new Point(317, 376);
            Firstbutton.Name = "Firstbutton";
            Firstbutton.Size = new Size(169, 136);
            Firstbutton.TabIndex = 0;
            Firstbutton.Text = "First";
            Firstbutton.UseVisualStyleBackColor = false;
            Firstbutton.Click += Firstbutton_Click;
            // 
            // Secondbutton
            // 
            Secondbutton.BackColor = Color.IndianRed;
            Secondbutton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Secondbutton.ForeColor = SystemColors.ButtonFace;
            Secondbutton.Location = new Point(524, 376);
            Secondbutton.Name = "Secondbutton";
            Secondbutton.Size = new Size(169, 136);
            Secondbutton.TabIndex = 1;
            Secondbutton.Text = "Second";
            Secondbutton.UseVisualStyleBackColor = false;
            Secondbutton.Click += Secondbutton_Click;
            // 
            // Lastbutton
            // 
            Lastbutton.BackColor = Color.IndianRed;
            Lastbutton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Lastbutton.ForeColor = SystemColors.ButtonFace;
            Lastbutton.Location = new Point(751, 376);
            Lastbutton.Name = "Lastbutton";
            Lastbutton.Size = new Size(169, 136);
            Lastbutton.TabIndex = 2;
            Lastbutton.Text = "Last";
            Lastbutton.UseVisualStyleBackColor = false;
            Lastbutton.Click += Lastbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 162);
            label1.Name = "label1";
            label1.Size = new Size(454, 74);
            label1.TabIndex = 3;
            label1.Text = "Hello My Name ";
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(429, 581);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(338, 91);
            BackMenubtn.TabIndex = 20;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // Tutorial2_3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1497, 707);
            Controls.Add(BackMenubtn);
            Controls.Add(label1);
            Controls.Add(Lastbutton);
            Controls.Add(Secondbutton);
            Controls.Add(Firstbutton);
            Name = "Tutorial2_3";
            Text = "Tutorial2_3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Firstbutton;
        private Button Secondbutton;
        private Button Lastbutton;
        private Label label1;
        private Button BackMenubtn;
    }
}