namespace ChpAndAss.Chapters
{
    partial class Tutorial_3_5
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
            Exitbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            TotalLabel = new Label();
            fiveCentsPictureBox = new PictureBox();
            tenCentsPictureBox = new PictureBox();
            fiftyCentsPictureBox = new PictureBox();
            twentyFiveCentsPictureBox = new PictureBox();
            BackMenubtn = new Button();
            ((System.ComponentModel.ISupportInitialize)fiveCentsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tenCentsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiftyCentsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)twentyFiveCentsPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Exitbtn
            // 
            Exitbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exitbtn.Location = new Point(370, 680);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(171, 69);
            Exitbtn.TabIndex = 0;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = true;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 37);
            label1.Name = "label1";
            label1.Size = new Size(203, 38);
            label1.TabIndex = 1;
            label1.Text = "Click The Coins";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(853, 301);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 2;
            label2.Text = "Total";
            // 
            // TotalLabel
            // 
            TotalLabel.BorderStyle = BorderStyle.FixedSingle;
            TotalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TotalLabel.Location = new Point(833, 362);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(113, 38);
            TotalLabel.TabIndex = 3;
            TotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fiveCentsPictureBox
            // 
            fiveCentsPictureBox.Image = Properties.Resources.F_5;
            fiveCentsPictureBox.Location = new Point(123, 116);
            fiveCentsPictureBox.Name = "fiveCentsPictureBox";
            fiveCentsPictureBox.Size = new Size(254, 232);
            fiveCentsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            fiveCentsPictureBox.TabIndex = 4;
            fiveCentsPictureBox.TabStop = false;
            fiveCentsPictureBox.Click += fiveCentsPictureBox_Click;
            // 
            // tenCentsPictureBox
            // 
            tenCentsPictureBox.Image = Properties.Resources.T_10;
            tenCentsPictureBox.Location = new Point(462, 116);
            tenCentsPictureBox.Name = "tenCentsPictureBox";
            tenCentsPictureBox.Size = new Size(254, 232);
            tenCentsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tenCentsPictureBox.TabIndex = 5;
            tenCentsPictureBox.TabStop = false;
            tenCentsPictureBox.Click += tenCentsPictureBox_Click;
            // 
            // fiftyCentsPictureBox
            // 
            fiftyCentsPictureBox.Image = Properties.Resources.F_50;
            fiftyCentsPictureBox.Location = new Point(123, 388);
            fiftyCentsPictureBox.Name = "fiftyCentsPictureBox";
            fiftyCentsPictureBox.Size = new Size(254, 232);
            fiftyCentsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            fiftyCentsPictureBox.TabIndex = 6;
            fiftyCentsPictureBox.TabStop = false;
            fiftyCentsPictureBox.Click += fiftyCentsPictureBox_Click;
            // 
            // twentyFiveCentsPictureBox
            // 
            twentyFiveCentsPictureBox.Image = Properties.Resources.T_25;
            twentyFiveCentsPictureBox.Location = new Point(462, 388);
            twentyFiveCentsPictureBox.Name = "twentyFiveCentsPictureBox";
            twentyFiveCentsPictureBox.Size = new Size(254, 232);
            twentyFiveCentsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            twentyFiveCentsPictureBox.TabIndex = 7;
            twentyFiveCentsPictureBox.TabStop = false;
            twentyFiveCentsPictureBox.Click += twentyFiveCentsPictureBox_Click;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(263, 819);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 16;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // Tutorial_3_5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1009, 972);
            Controls.Add(BackMenubtn);
            Controls.Add(twentyFiveCentsPictureBox);
            Controls.Add(fiftyCentsPictureBox);
            Controls.Add(tenCentsPictureBox);
            Controls.Add(fiveCentsPictureBox);
            Controls.Add(TotalLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Exitbtn);
            Name = "Tutorial_3_5";
            Text = "Tutorial_3_5";
            ((System.ComponentModel.ISupportInitialize)fiveCentsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tenCentsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiftyCentsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)twentyFiveCentsPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exitbtn;
        private Label label1;
        private Label label2;
        private Label TotalLabel;
        private PictureBox fiveCentsPictureBox;
        private PictureBox tenCentsPictureBox;
        private PictureBox fiftyCentsPictureBox;
        private PictureBox twentyFiveCentsPictureBox;
        private Button BackMenubtn;
    }
}