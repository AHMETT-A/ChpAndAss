namespace ChpAndAss.Assigments
{
    partial class A_18
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
            btnCalculate = new Button();
            label1 = new Label();
            lblResult = new Label();
            txtCookies = new TextBox();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(505, 285);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(208, 79);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate \r\nCalories";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 118);
            label1.Name = "label1";
            label1.Size = new Size(280, 28);
            label1.TabIndex = 1;
            label1.Text = "Enter number of cookies eaten:";
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(505, 191);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(229, 38);
            lblResult.TabIndex = 2;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCookies
            // 
            txtCookies.Location = new Point(505, 118);
            txtCookies.Name = "txtCookies";
            txtCookies.Size = new Size(229, 31);
            txtCookies.TabIndex = 3;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(455, 474);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(279, 91);
            BackMenubtn.TabIndex = 21;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_18
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 782);
            Controls.Add(BackMenubtn);
            Controls.Add(txtCookies);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Name = "A_18";
            Text = "A_18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label label1;
        private Label lblResult;
        private TextBox txtCookies;
        private Button BackMenubtn;
    }
}