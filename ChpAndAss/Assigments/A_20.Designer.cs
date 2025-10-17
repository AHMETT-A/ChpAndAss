namespace ChpAndAss.Assigments
{
    partial class A_20
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblMonthlyTotal = new Label();
            btnCalculate = new Button();
            txtLoan = new TextBox();
            txtInsurance = new TextBox();
            txtGas = new TextBox();
            txtOil = new TextBox();
            txtMaintenance = new TextBox();
            txtTires = new TextBox();
            BackMenubtn = new Button();
            lblAnnualTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label1.Location = new Point(217, 60);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 0;
            label1.Text = "Loan Payment:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label2.Location = new Point(262, 142);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 1;
            label2.Text = "Insurance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label3.Location = new Point(262, 219);
            label3.Name = "label3";
            label3.Size = new Size(60, 30);
            label3.TabIndex = 2;
            label3.Text = "Gas :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label4.Location = new Point(262, 306);
            label4.Name = "label4";
            label4.Size = new Size(53, 30);
            label4.TabIndex = 3;
            label4.Text = "Oil :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label5.Location = new Point(262, 398);
            label5.Name = "label5";
            label5.Size = new Size(70, 30);
            label5.TabIndex = 4;
            label5.Text = "Tires :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label6.Location = new Point(231, 481);
            label6.Name = "label6";
            label6.Size = new Size(141, 30);
            label6.TabIndex = 5;
            label6.Text = "Maintenance:";
            // 
            // lblMonthlyTotal
            // 
            lblMonthlyTotal.BorderStyle = BorderStyle.FixedSingle;
            lblMonthlyTotal.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblMonthlyTotal.Location = new Point(802, 123);
            lblMonthlyTotal.Name = "lblMonthlyTotal";
            lblMonthlyTotal.Size = new Size(165, 57);
            lblMonthlyTotal.TabIndex = 6;
            lblMonthlyTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            btnCalculate.Location = new Point(802, 331);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(169, 64);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate Costs";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtLoan
            // 
            txtLoan.Location = new Point(398, 59);
            txtLoan.Name = "txtLoan";
            txtLoan.Size = new Size(219, 31);
            txtLoan.TabIndex = 8;
            // 
            // txtInsurance
            // 
            txtInsurance.Location = new Point(398, 136);
            txtInsurance.Name = "txtInsurance";
            txtInsurance.Size = new Size(219, 31);
            txtInsurance.TabIndex = 9;
            // 
            // txtGas
            // 
            txtGas.Location = new Point(398, 213);
            txtGas.Name = "txtGas";
            txtGas.Size = new Size(219, 31);
            txtGas.TabIndex = 10;
            // 
            // txtOil
            // 
            txtOil.Location = new Point(398, 300);
            txtOil.Name = "txtOil";
            txtOil.Size = new Size(219, 31);
            txtOil.TabIndex = 11;
            // 
            // txtMaintenance
            // 
            txtMaintenance.Location = new Point(398, 482);
            txtMaintenance.Name = "txtMaintenance";
            txtMaintenance.Size = new Size(219, 31);
            txtMaintenance.TabIndex = 12;
            // 
            // txtTires
            // 
            txtTires.Location = new Point(398, 392);
            txtTires.Name = "txtTires";
            txtTires.Size = new Size(219, 31);
            txtTires.TabIndex = 13;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(368, 624);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(303, 91);
            BackMenubtn.TabIndex = 21;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // lblAnnualTotal
            // 
            lblAnnualTotal.BorderStyle = BorderStyle.FixedSingle;
            lblAnnualTotal.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblAnnualTotal.Location = new Point(802, 219);
            lblAnnualTotal.Name = "lblAnnualTotal";
            lblAnnualTotal.Size = new Size(165, 57);
            lblAnnualTotal.TabIndex = 22;
            lblAnnualTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // A_20
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 742);
            Controls.Add(lblAnnualTotal);
            Controls.Add(BackMenubtn);
            Controls.Add(txtTires);
            Controls.Add(txtMaintenance);
            Controls.Add(txtOil);
            Controls.Add(txtGas);
            Controls.Add(txtInsurance);
            Controls.Add(txtLoan);
            Controls.Add(btnCalculate);
            Controls.Add(lblMonthlyTotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "A_20";
            Text = "A_20";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblMonthlyTotal;
        private Button btnCalculate;
        private TextBox txtLoan;
        private TextBox txtInsurance;
        private TextBox txtGas;
        private TextBox txtOil;
        private TextBox txtMaintenance;
        private TextBox txtTires;
        private Button BackMenubtn;
        private Label lblAnnualTotal;
    }
}