namespace ChpAndAss.Chapters
{
    partial class Tutorial_3_2
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
            calculateButton = new Button();
            exitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Mpglabel = new Label();
            MilestextBox = new TextBox();
            GallonstextBox = new TextBox();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Segoe UI Semilight", 12F);
            calculateButton.Location = new Point(280, 446);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(176, 95);
            calculateButton.TabIndex = 0;
            calculateButton.Text = " Calculate MPG ";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI Semilight", 12F);
            exitButton.Location = new Point(528, 446);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(176, 95);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 11F);
            label1.Location = new Point(134, 76);
            label1.Name = "label1";
            label1.Size = new Size(338, 30);
            label1.TabIndex = 2;
            label1.Text = " Enter the number of miles driven: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 11F);
            label2.Location = new Point(153, 199);
            label2.Name = "label2";
            label2.Size = new Size(303, 30);
            label2.TabIndex = 3;
            label2.Text = "  Enter the gallons of gas used:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 11F);
            label3.Location = new Point(253, 311);
            label3.Name = "label3";
            label3.Size = new Size(172, 30);
            label3.TabIndex = 4;
            label3.Text = " Your car’s MPG: ";
            // 
            // Mpglabel
            // 
            Mpglabel.BorderStyle = BorderStyle.FixedSingle;
            Mpglabel.Location = new Point(514, 308);
            Mpglabel.Name = "Mpglabel";
            Mpglabel.Size = new Size(283, 38);
            Mpglabel.TabIndex = 5;
            Mpglabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MilestextBox
            // 
            MilestextBox.Location = new Point(514, 77);
            MilestextBox.Name = "MilestextBox";
            MilestextBox.Size = new Size(283, 31);
            MilestextBox.TabIndex = 6;
            // 
            // GallonstextBox
            // 
            GallonstextBox.Location = new Point(514, 198);
            GallonstextBox.Name = "GallonstextBox";
            GallonstextBox.Size = new Size(283, 31);
            GallonstextBox.TabIndex = 7;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(280, 609);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 13;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // Tutorial_3_2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(933, 722);
            Controls.Add(BackMenubtn);
            Controls.Add(GallonstextBox);
            Controls.Add(MilestextBox);
            Controls.Add(Mpglabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Name = "Tutorial_3_2";
            Text = "Tutorial_3_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private Button exitButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Mpglabel;
        private TextBox MilestextBox;
        private TextBox GallonstextBox;
        private Button BackMenubtn;
    }
}