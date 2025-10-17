namespace ChpAndAss.Chapters
{
    partial class Tutorial_3_4
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
            Clearbtn = new Button();
            exitbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Avaregalabal = new Label();
            test1textBox = new TextBox();
            test2textBox = new TextBox();
            test3textBox = new TextBox();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // Calbtn
            // 
            Calbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Calbtn.Location = new Point(220, 522);
            Calbtn.Name = "Calbtn";
            Calbtn.Size = new Size(166, 100);
            Calbtn.TabIndex = 0;
            Calbtn.Text = " Calculate Sale Price ";
            Calbtn.UseVisualStyleBackColor = true;
            Calbtn.Click += Calbtn_Click;
            // 
            // Clearbtn
            // 
            Clearbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Clearbtn.Location = new Point(442, 522);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(166, 100);
            Clearbtn.TabIndex = 1;
            Clearbtn.Text = "Clear";
            Clearbtn.UseVisualStyleBackColor = true;
            Clearbtn.Click += Clearbtn_Click;
            // 
            // exitbtn
            // 
            exitbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            exitbtn.Location = new Point(682, 522);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(166, 100);
            exitbtn.TabIndex = 2;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label1.Location = new Point(245, 62);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 3;
            label1.Text = " Test 1: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label2.Location = new Point(245, 161);
            label2.Name = "label2";
            label2.Size = new Size(95, 32);
            label2.TabIndex = 4;
            label2.Text = " Test 2: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label3.Location = new Point(245, 254);
            label3.Name = "label3";
            label3.Size = new Size(95, 32);
            label3.TabIndex = 5;
            label3.Text = " Test 3: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label4.Location = new Point(178, 373);
            label4.Name = "label4";
            label4.Size = new Size(230, 32);
            label4.TabIndex = 6;
            label4.Text = " Average Test Score: ";
            // 
            // Avaregalabal
            // 
            Avaregalabal.BorderStyle = BorderStyle.FixedSingle;
            Avaregalabal.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Avaregalabal.Location = new Point(442, 370);
            Avaregalabal.Name = "Avaregalabal";
            Avaregalabal.Size = new Size(246, 38);
            Avaregalabal.TabIndex = 7;
            Avaregalabal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // test1textBox
            // 
            test1textBox.Location = new Point(442, 62);
            test1textBox.Name = "test1textBox";
            test1textBox.Size = new Size(246, 31);
            test1textBox.TabIndex = 8;
            // 
            // test2textBox
            // 
            test2textBox.Location = new Point(442, 155);
            test2textBox.Name = "test2textBox";
            test2textBox.Size = new Size(246, 31);
            test2textBox.TabIndex = 9;
            // 
            // test3textBox
            // 
            test3textBox.Location = new Point(442, 254);
            test3textBox.Name = "test3textBox";
            test3textBox.Size = new Size(246, 31);
            test3textBox.TabIndex = 10;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(303, 691);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 15;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // Tutorial_3_4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 818);
            Controls.Add(BackMenubtn);
            Controls.Add(test3textBox);
            Controls.Add(test2textBox);
            Controls.Add(test1textBox);
            Controls.Add(Avaregalabal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exitbtn);
            Controls.Add(Clearbtn);
            Controls.Add(Calbtn);
            Name = "Tutorial_3_4";
            Text = "Tutorial_3_4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calbtn;
        private Button Clearbtn;
        private Button exitbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Avaregalabal;
        private TextBox test1textBox;
        private TextBox test2textBox;
        private TextBox test3textBox;
        private Button BackMenubtn;
    }
}