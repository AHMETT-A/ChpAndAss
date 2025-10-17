namespace ChpAndAss.Assigments
{
    partial class A_17
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
            lblResult = new Label();
            txtReplacementCost = new TextBox();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(478, 330);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(181, 74);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(453, 242);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(230, 53);
            lblResult.TabIndex = 1;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtReplacementCost
            // 
            txtReplacementCost.Location = new Point(453, 167);
            txtReplacementCost.Name = "txtReplacementCost";
            txtReplacementCost.Size = new Size(230, 31);
            txtReplacementCost.TabIndex = 2;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(438, 564);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(279, 91);
            BackMenubtn.TabIndex = 20;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_17
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 716);
            Controls.Add(BackMenubtn);
            Controls.Add(txtReplacementCost);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Name = "A_17";
            Text = "A_17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label lblResult;
        private TextBox txtReplacementCost;
        private Button BackMenubtn;
    }
}