namespace ChpAndAss.Assigments
{
    partial class A_15
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
            BackMenubtn = new Button();
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(456, 380);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(159, 95);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate MBI";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(355, 554);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(345, 91);
            BackMenubtn.TabIndex = 18;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 79);
            label1.Name = "label1";
            label1.Size = new Size(156, 32);
            label1.TabIndex = 19;
            label1.Text = "Enter weight :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 201);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 20;
            label2.Text = "Enter height :";
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(422, 279);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(233, 38);
            lblResult.TabIndex = 21;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(422, 82);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(225, 31);
            txtWeight.TabIndex = 22;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(422, 195);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(225, 31);
            txtHeight.TabIndex = 23;
            // 
            // A_15
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 702);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BackMenubtn);
            Controls.Add(btnCalculate);
            Name = "A_15";
            Text = "A_15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button BackMenubtn;
        private Label label1;
        private Label label2;
        private Label lblResult;
        private TextBox txtWeight;
        private TextBox txtHeight;
    }
}