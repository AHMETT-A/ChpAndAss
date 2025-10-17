namespace ChpAndAss.Assigments
{
    partial class A_22
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
            txtPropertyValue = new TextBox();
            label1 = new Label();
            lblResult = new Label();
            btnCalculate = new Button();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // txtPropertyValue
            // 
            txtPropertyValue.Location = new Point(500, 108);
            txtPropertyValue.Name = "txtPropertyValue";
            txtPropertyValue.Size = new Size(261, 31);
            txtPropertyValue.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 109);
            label1.Name = "label1";
            label1.Size = new Size(248, 30);
            label1.TabIndex = 1;
            label1.Text = "Enter Property Value ($):";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(479, 191);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(282, 45);
            lblResult.TabIndex = 2;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(499, 311);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(262, 85);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate Property Tax";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(309, 528);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(234, 91);
            BackMenubtn.TabIndex = 23;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_22
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 662);
            Controls.Add(BackMenubtn);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(txtPropertyValue);
            Name = "A_22";
            Text = "A_22";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPropertyValue;
        private Label label1;
        private Label lblResult;
        private Button btnCalculate;
        private Button BackMenubtn;
    }
}