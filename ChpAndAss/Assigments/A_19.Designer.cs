namespace ChpAndAss.Assigments
{
    partial class A_19
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
            BackMenubtn = new Button();
            btnReset = new Button();
            Exitbtn = new Button();
            label1 = new Label();
            lblTotalCalories = new Label();
            picBanana = new PictureBox();
            picApple = new PictureBox();
            picOrange = new PictureBox();
            picPear = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBanana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picApple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOrange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPear).BeginInit();
            SuspendLayout();
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(302, 570);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(303, 91);
            BackMenubtn.TabIndex = 20;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            btnReset.Location = new Point(709, 451);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(143, 85);
            btnReset.TabIndex = 21;
            btnReset.Text = "Resets total";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            Exitbtn.Location = new Point(885, 451);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(143, 85);
            Exitbtn.TabIndex = 22;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(769, 205);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 23;
            label1.Text = "Total Calories:";
            // 
            // lblTotalCalories
            // 
            lblTotalCalories.BorderStyle = BorderStyle.FixedSingle;
            lblTotalCalories.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTotalCalories.Location = new Point(769, 285);
            lblTotalCalories.Name = "lblTotalCalories";
            lblTotalCalories.Size = new Size(191, 38);
            lblTotalCalories.TabIndex = 24;
            lblTotalCalories.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picBanana
            // 
            picBanana.Image = Properties.Resources.Banana;
            picBanana.Location = new Point(96, 79);
            picBanana.Name = "picBanana";
            picBanana.Size = new Size(170, 156);
            picBanana.SizeMode = PictureBoxSizeMode.StretchImage;
            picBanana.TabIndex = 25;
            picBanana.TabStop = false;
            picBanana.Click += picBanana_Click;
            // 
            // picApple
            // 
            picApple.Image = Properties.Resources.Apple;
            picApple.Location = new Point(333, 79);
            picApple.Name = "picApple";
            picApple.Size = new Size(170, 156);
            picApple.SizeMode = PictureBoxSizeMode.StretchImage;
            picApple.TabIndex = 26;
            picApple.TabStop = false;
            picApple.Click += picApple_Click;
            // 
            // picOrange
            // 
            picOrange.Image = Properties.Resources.Orange;
            picOrange.Location = new Point(96, 285);
            picOrange.Name = "picOrange";
            picOrange.Size = new Size(170, 156);
            picOrange.SizeMode = PictureBoxSizeMode.StretchImage;
            picOrange.TabIndex = 27;
            picOrange.TabStop = false;
            picOrange.Click += picOrange_Click;
            // 
            // picPear
            // 
            picPear.Image = Properties.Resources.Pear;
            picPear.Location = new Point(333, 285);
            picPear.Name = "picPear";
            picPear.Size = new Size(170, 156);
            picPear.SizeMode = PictureBoxSizeMode.StretchImage;
            picPear.TabIndex = 28;
            picPear.TabStop = false;
            picPear.Click += picPear_Click;
            // 
            // A_19
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 685);
            Controls.Add(picPear);
            Controls.Add(picOrange);
            Controls.Add(picApple);
            Controls.Add(picBanana);
            Controls.Add(lblTotalCalories);
            Controls.Add(label1);
            Controls.Add(Exitbtn);
            Controls.Add(btnReset);
            Controls.Add(BackMenubtn);
            Name = "A_19";
            Text = "A_19";
            ((System.ComponentModel.ISupportInitialize)picBanana).EndInit();
            ((System.ComponentModel.ISupportInitialize)picApple).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOrange).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackMenubtn;
        private Button btnReset;
        private Button Exitbtn;
        private Label label1;
        private Label lblTotalCalories;
        private PictureBox picBanana;
        private PictureBox picApple;
        private PictureBox picOrange;
        private PictureBox picPear;
    }
}