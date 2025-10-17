namespace ChpAndAss.Assigments
{
    partial class A_11
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
            lblTip = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            btnCalculate = new Button();
            txtFoodCharge = new TextBox();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 75);
            label1.Name = "label1";
            label1.Size = new Size(269, 38);
            label1.TabIndex = 0;
            label1.Text = "Enter Food Charge:";
            // 
            // lblTip
            // 
            lblTip.BorderStyle = BorderStyle.FixedSingle;
            lblTip.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTip.Location = new Point(376, 200);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(214, 38);
            lblTip.TabIndex = 1;
            lblTip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTax
            // 
            lblTax.BorderStyle = BorderStyle.FixedSingle;
            lblTax.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTax.Location = new Point(376, 306);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(214, 38);
            lblTax.TabIndex = 2;
            lblTax.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.Location = new Point(376, 399);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(214, 38);
            lblTotal.TabIndex = 3;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(392, 511);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(182, 63);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtFoodCharge
            // 
            txtFoodCharge.Location = new Point(703, 304);
            txtFoodCharge.Name = "txtFoodCharge";
            txtFoodCharge.Size = new Size(222, 31);
            txtFoodCharge.TabIndex = 5;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(344, 650);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 17;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_11
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1340, 818);
            Controls.Add(BackMenubtn);
            Controls.Add(txtFoodCharge);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblTip);
            Controls.Add(label1);
            Name = "A_11";
            Text = "A_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTip;
        private Label lblTax;
        private Label lblTotal;
        private Button btnCalculate;
        private TextBox txtFoodCharge;
        private Button BackMenubtn;
    }
}