namespace ChpAndAss.Chapters
{
    partial class T_1
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
            Exitbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            txtHours = new TextBox();
            txtRate = new TextBox();
            SuspendLayout();
            // 
            // Calbtn
            // 
            Calbtn.BackColor = Color.PeachPuff;
            Calbtn.Font = new Font("Cambria", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Calbtn.Location = new Point(118, 320);
            Calbtn.Name = "Calbtn";
            Calbtn.Size = new Size(176, 66);
            Calbtn.TabIndex = 0;
            Calbtn.Text = "Cal";
            Calbtn.UseVisualStyleBackColor = false;
            Calbtn.Click += Calbtn_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = Color.PeachPuff;
            Exitbtn.Font = new Font("Cambria", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exitbtn.Location = new Point(334, 320);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(162, 66);
            Exitbtn.TabIndex = 1;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = false;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Cambria", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 123);
            label1.Name = "label1";
            label1.Size = new Size(230, 23);
            label1.TabIndex = 2;
            label1.Text = "Number of Hours Worked";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Cambria", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(118, 200);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 3;
            label2.Text = "Houly Pay Rate";
            // 
            // txtHours
            // 
            txtHours.Location = new Point(334, 117);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(176, 31);
            txtHours.TabIndex = 4;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(334, 200);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(176, 31);
            txtRate.TabIndex = 5;
            // 
            // T_1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRate);
            Controls.Add(txtHours);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Exitbtn);
            Controls.Add(Calbtn);
            Name = "T_1";
            Text = "T_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calbtn;
        private Button Exitbtn;
        private Label label1;
        private Label label2;
        private TextBox txtHours;
        private TextBox txtRate;
    }
}