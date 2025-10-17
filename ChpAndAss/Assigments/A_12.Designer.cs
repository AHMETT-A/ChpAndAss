namespace ChpAndAss.Assigments
{
    partial class A_12
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
            label1 = new Label();
            btn5Hours = new Button();
            btn8Hours = new Button();
            btn12Hours = new Button();
            lblResult = new Label();
            txtSpeed = new TextBox();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 118);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter car speed :";
            // 
            // btn5Hours
            // 
            btn5Hours.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            btn5Hours.Location = new Point(142, 328);
            btn5Hours.Name = "btn5Hours";
            btn5Hours.Size = new Size(163, 110);
            btn5Hours.TabIndex = 1;
            btn5Hours.Text = "Distance in 5 Hours";
            btn5Hours.UseVisualStyleBackColor = true;
            btn5Hours.Click += btn5Hours_Click;
            // 
            // btn8Hours
            // 
            btn8Hours.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            btn8Hours.Location = new Point(322, 328);
            btn8Hours.Name = "btn8Hours";
            btn8Hours.Size = new Size(163, 110);
            btn8Hours.TabIndex = 2;
            btn8Hours.Text = "Distance in 8 Hours";
            btn8Hours.UseVisualStyleBackColor = true;
            btn8Hours.Click += btn8Hours_Click;
            // 
            // btn12Hours
            // 
            btn12Hours.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            btn12Hours.Location = new Point(523, 328);
            btn12Hours.Name = "btn12Hours";
            btn12Hours.Size = new Size(163, 110);
            btn12Hours.TabIndex = 3;
            btn12Hours.Text = "Distance in 12 Hours";
            btn12Hours.UseVisualStyleBackColor = true;
            btn12Hours.Click += btn12Hours_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(244, 225);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(248, 38);
            lblResult.TabIndex = 4;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSpeed
            // 
            txtSpeed.Location = new Point(415, 118);
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(220, 31);
            txtSpeed.TabIndex = 5;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(231, 492);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(338, 91);
            BackMenubtn.TabIndex = 18;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_12
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 595);
            Controls.Add(BackMenubtn);
            Controls.Add(txtSpeed);
            Controls.Add(lblResult);
            Controls.Add(btn12Hours);
            Controls.Add(btn8Hours);
            Controls.Add(btn5Hours);
            Controls.Add(label1);
            Name = "A_12";
            Text = "A_12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn5Hours;
        private Button btn8Hours;
        private Button btn12Hours;
        private Label lblResult;
        private TextBox txtSpeed;
        private Button BackMenubtn;
    }
}