namespace ChpAndAss.Assigments
{
    partial class A_8
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
            btnShowTails = new Button();
            btnShowHeads = new Button();
            pictureBoxTwoImgs = new PictureBox();
            label1 = new Label();
            BackMenubtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTwoImgs).BeginInit();
            SuspendLayout();
            // 
            // btnShowTails
            // 
            btnShowTails.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnShowTails.Location = new Point(200, 352);
            btnShowTails.Name = "btnShowTails";
            btnShowTails.Size = new Size(157, 85);
            btnShowTails.TabIndex = 0;
            btnShowTails.Text = "Show To Tail";
            btnShowTails.UseVisualStyleBackColor = true;
            btnShowTails.Click += btnShowTails_Click;
            // 
            // btnShowHeads
            // 
            btnShowHeads.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnShowHeads.Location = new Point(482, 352);
            btnShowHeads.Name = "btnShowHeads";
            btnShowHeads.Size = new Size(153, 85);
            btnShowHeads.TabIndex = 1;
            btnShowHeads.Text = "Show To Head";
            btnShowHeads.UseVisualStyleBackColor = true;
            btnShowHeads.Click += btnShowHeads_Click;
            // 
            // pictureBoxTwoImgs
            // 
            pictureBoxTwoImgs.Image = Properties.Resources.Tail;
            pictureBoxTwoImgs.Location = new Point(321, 86);
            pictureBoxTwoImgs.Name = "pictureBoxTwoImgs";
            pictureBoxTwoImgs.Size = new Size(220, 223);
            pictureBoxTwoImgs.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTwoImgs.TabIndex = 2;
            pictureBoxTwoImgs.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS PGothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 25);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 3;
            label1.Text = "Head And Tails";
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(250, 506);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 11;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(954, 623);
            Controls.Add(BackMenubtn);
            Controls.Add(label1);
            Controls.Add(pictureBoxTwoImgs);
            Controls.Add(btnShowHeads);
            Controls.Add(btnShowTails);
            Name = "A_8";
            Text = "A_8";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTwoImgs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowTails;
        private Button btnShowHeads;
        private PictureBox pictureBoxTwoImgs;
        private Label label1;
        private Button BackMenubtn;
    }
}