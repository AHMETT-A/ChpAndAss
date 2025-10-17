namespace ChpAndAss.Assigments
{
    partial class A_6
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
            picOne = new PictureBox();
            picTwo = new PictureBox();
            picThree = new PictureBox();
            picFour = new PictureBox();
            picFive = new PictureBox();
            BackMenubtn = new Button();
            ((System.ComponentModel.ISupportInitialize)picOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFive).BeginInit();
            SuspendLayout();
            // 
            // picOne
            // 
            picOne.Image = Properties.Resources.One;
            picOne.Location = new Point(45, 51);
            picOne.Name = "picOne";
            picOne.Size = new Size(220, 224);
            picOne.SizeMode = PictureBoxSizeMode.StretchImage;
            picOne.TabIndex = 0;
            picOne.TabStop = false;
            picOne.Click += picOne_Click;
            // 
            // picTwo
            // 
            picTwo.Image = Properties.Resources.Two;
            picTwo.Location = new Point(357, 240);
            picTwo.Name = "picTwo";
            picTwo.Size = new Size(220, 224);
            picTwo.SizeMode = PictureBoxSizeMode.StretchImage;
            picTwo.TabIndex = 1;
            picTwo.TabStop = false;
            picTwo.Click += picTwo_Click;
            // 
            // picThree
            // 
            picThree.Image = Properties.Resources.Tree;
            picThree.Location = new Point(667, 442);
            picThree.Name = "picThree";
            picThree.Size = new Size(220, 224);
            picThree.SizeMode = PictureBoxSizeMode.StretchImage;
            picThree.TabIndex = 2;
            picThree.TabStop = false;
            picThree.Click += picThree_Click;
            // 
            // picFour
            // 
            picFour.Image = Properties.Resources.Four;
            picFour.Location = new Point(667, 51);
            picFour.Name = "picFour";
            picFour.Size = new Size(220, 224);
            picFour.SizeMode = PictureBoxSizeMode.StretchImage;
            picFour.TabIndex = 3;
            picFour.TabStop = false;
            picFour.Click += picFour_Click;
            // 
            // picFive
            // 
            picFive.Image = Properties.Resources.Five;
            picFive.Location = new Point(45, 442);
            picFive.Name = "picFive";
            picFive.Size = new Size(220, 224);
            picFive.SizeMode = PictureBoxSizeMode.StretchImage;
            picFive.TabIndex = 4;
            picFive.TabStop = false;
            picFive.Click += picFive_Click;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(274, 717);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 9;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(937, 820);
            Controls.Add(BackMenubtn);
            Controls.Add(picFive);
            Controls.Add(picFour);
            Controls.Add(picThree);
            Controls.Add(picTwo);
            Controls.Add(picOne);
            Name = "A_6";
            Text = "A_6";
            ((System.ComponentModel.ISupportInitialize)picOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThree).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFour).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFive).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picOne;
        private PictureBox picTwo;
        private PictureBox picThree;
        private PictureBox picFour;
        private PictureBox picFive;
        private Button BackMenubtn;
    }
}