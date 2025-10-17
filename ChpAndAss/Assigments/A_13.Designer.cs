namespace ChpAndAss.Assigments
{
    partial class A_13
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
            lblPurchase = new Label();
            txtPurchase = new TextBox();
            lblStateTax = new Label();
            lblCountyTax = new Label();
            lblTotalTax = new Label();
            lblTotalSale = new Label();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(470, 344);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(174, 88);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate Total";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblPurchase
            // 
            lblPurchase.AutoSize = true;
            lblPurchase.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPurchase.Location = new Point(314, 87);
            lblPurchase.Name = "lblPurchase";
            lblPurchase.Size = new Size(239, 30);
            lblPurchase.TabIndex = 1;
            lblPurchase.Text = "Enter purchase amount:";
            // 
            // txtPurchase
            // 
            txtPurchase.Location = new Point(578, 88);
            txtPurchase.Name = "txtPurchase";
            txtPurchase.Size = new Size(238, 31);
            txtPurchase.TabIndex = 2;
            // 
            // lblStateTax
            // 
            lblStateTax.BorderStyle = BorderStyle.FixedSingle;
            lblStateTax.Location = new Point(199, 226);
            lblStateTax.Name = "lblStateTax";
            lblStateTax.Size = new Size(151, 38);
            lblStateTax.TabIndex = 3;
            lblStateTax.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCountyTax
            // 
            lblCountyTax.BorderStyle = BorderStyle.FixedSingle;
            lblCountyTax.Location = new Point(402, 226);
            lblCountyTax.Name = "lblCountyTax";
            lblCountyTax.Size = new Size(151, 38);
            lblCountyTax.TabIndex = 4;
            lblCountyTax.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalTax
            // 
            lblTotalTax.BorderStyle = BorderStyle.FixedSingle;
            lblTotalTax.Location = new Point(590, 226);
            lblTotalTax.Name = "lblTotalTax";
            lblTotalTax.Size = new Size(151, 38);
            lblTotalTax.TabIndex = 5;
            lblTotalTax.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalSale
            // 
            lblTotalSale.BorderStyle = BorderStyle.FixedSingle;
            lblTotalSale.Location = new Point(768, 226);
            lblTotalSale.Name = "lblTotalSale";
            lblTotalSale.Size = new Size(151, 38);
            lblTotalSale.TabIndex = 6;
            lblTotalSale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(390, 500);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(338, 91);
            BackMenubtn.TabIndex = 19;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_13
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 627);
            Controls.Add(BackMenubtn);
            Controls.Add(lblTotalSale);
            Controls.Add(lblTotalTax);
            Controls.Add(lblCountyTax);
            Controls.Add(lblStateTax);
            Controls.Add(txtPurchase);
            Controls.Add(lblPurchase);
            Controls.Add(btnCalculate);
            Name = "A_13";
            Text = "A_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label lblPurchase;
        private TextBox txtPurchase;
        private Label lblStateTax;
        private Label lblCountyTax;
        private Label lblTotalTax;
        private Label lblTotalSale;
        private Button BackMenubtn;
    }
}