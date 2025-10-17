namespace ChpAndAss.Chapters
{
    partial class Tutorial2_2
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
            showAnswerbtn = new Button();
            answerLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // showAnswerbtn
            // 
            showAnswerbtn.BackColor = Color.Turquoise;
            showAnswerbtn.Location = new Point(246, 233);
            showAnswerbtn.Name = "showAnswerbtn";
            showAnswerbtn.Size = new Size(201, 85);
            showAnswerbtn.TabIndex = 0;
            showAnswerbtn.Text = "Show The Answer";
            showAnswerbtn.UseVisualStyleBackColor = false;
            showAnswerbtn.Click += showAnswerbtn_Click;
            // 
            // answerLabel
            // 
            answerLabel.BorderStyle = BorderStyle.FixedSingle;
            answerLabel.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answerLabel.Location = new Point(185, 143);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(310, 52);
            answerLabel.TabIndex = 1;
            answerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(76, 55);
            label2.Name = "label2";
            label2.Size = new Size(565, 32);
            label2.TabIndex = 2;
            label2.Text = "  What former U.S. president is known for going on ";
            // 
            // Tutorial2_2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(answerLabel);
            Controls.Add(showAnswerbtn);
            Name = "Tutorial2_2";
            Text = "Tutorial2_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button showAnswerbtn;
        private Label answerLabel;
        private Label label2;
    }
}