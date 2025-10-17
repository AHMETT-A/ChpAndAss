namespace ChpAndAss.Assigments
{
    partial class A_21
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
            txtSquareFeet = new TextBox();
            label1 = new Label();
            txtPricePerGallon = new TextBox();
            label2 = new Label();
            btnCalculate = new Button();
            lblGallons = new Label();
            lblLabor = new Label();
            lblPaintCost = new Label();
            lblLaborCost = new Label();
            lblTotalCost = new Label();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // txtSquareFeet
            // 
            txtSquareFeet.Location = new Point(427, 80);
            txtSquareFeet.Name = "txtSquareFeet";
            txtSquareFeet.Size = new Size(233, 31);
            txtSquareFeet.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 79);
            label1.Name = "label1";
            label1.Size = new Size(260, 30);
            label1.TabIndex = 1;
            label1.Text = "Square feet of wall space:";
            // 
            // txtPricePerGallon
            // 
            txtPricePerGallon.Location = new Point(427, 158);
            txtPricePerGallon.Name = "txtPricePerGallon";
            txtPricePerGallon.Size = new Size(233, 31);
            txtPricePerGallon.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 159);
            label2.Name = "label2";
            label2.Size = new Size(249, 30);
            label2.TabIndex = 3;
            label2.Text = "Price of paint per gallon:";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Rockwell Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(355, 655);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(182, 66);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate Estimate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblGallons
            // 
            lblGallons.BorderStyle = BorderStyle.FixedSingle;
            lblGallons.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGallons.Location = new Point(318, 253);
            lblGallons.Name = "lblGallons";
            lblGallons.Size = new Size(249, 30);
            lblGallons.TabIndex = 5;
            lblGallons.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLabor
            // 
            lblLabor.BorderStyle = BorderStyle.FixedSingle;
            lblLabor.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLabor.Location = new Point(318, 335);
            lblLabor.Name = "lblLabor";
            lblLabor.Size = new Size(249, 30);
            lblLabor.TabIndex = 6;
            lblLabor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPaintCost
            // 
            lblPaintCost.BorderStyle = BorderStyle.FixedSingle;
            lblPaintCost.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPaintCost.Location = new Point(318, 406);
            lblPaintCost.Name = "lblPaintCost";
            lblPaintCost.Size = new Size(249, 30);
            lblPaintCost.TabIndex = 7;
            lblPaintCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLaborCost
            // 
            lblLaborCost.BorderStyle = BorderStyle.FixedSingle;
            lblLaborCost.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLaborCost.Location = new Point(318, 483);
            lblLaborCost.Name = "lblLaborCost";
            lblLaborCost.Size = new Size(249, 30);
            lblLaborCost.TabIndex = 8;
            lblLaborCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCost
            // 
            lblTotalCost.BorderStyle = BorderStyle.FixedSingle;
            lblTotalCost.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalCost.Location = new Point(318, 558);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(249, 30);
            lblTotalCost.TabIndex = 9;
            lblTotalCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(333, 787);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(234, 91);
            BackMenubtn.TabIndex = 22;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_21
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 890);
            Controls.Add(BackMenubtn);
            Controls.Add(lblTotalCost);
            Controls.Add(lblLaborCost);
            Controls.Add(lblPaintCost);
            Controls.Add(lblLabor);
            Controls.Add(lblGallons);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(txtPricePerGallon);
            Controls.Add(label1);
            Controls.Add(txtSquareFeet);
            Name = "A_21";
            Text = "A_21";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSquareFeet;
        private Label label1;
        private TextBox txtPricePerGallon;
        private Label label2;
        private Button btnCalculate;
        private Label lblGallons;
        private Label lblLabor;
        private Label lblPaintCost;
        private Label lblLaborCost;
        private Label lblTotalCost;
        private Button BackMenubtn;
    }
}