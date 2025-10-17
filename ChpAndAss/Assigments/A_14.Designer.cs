namespace ChpAndAss.Assigments
{
    partial class A_14
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
            txtTemp = new TextBox();
            btnToFahrenheit = new Button();
            btnToCelsius = new Button();
            lblResult = new Label();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(132, 143);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter temperature :";
            // 
            // txtTemp
            // 
            txtTemp.Location = new Point(424, 146);
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(225, 31);
            txtTemp.TabIndex = 1;
            // 
            // btnToFahrenheit
            // 
            btnToFahrenheit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnToFahrenheit.Location = new Point(293, 392);
            btnToFahrenheit.Name = "btnToFahrenheit";
            btnToFahrenheit.Size = new Size(169, 87);
            btnToFahrenheit.TabIndex = 2;
            btnToFahrenheit.Text = "Convert to Fahrenheit";
            btnToFahrenheit.UseVisualStyleBackColor = true;
            btnToFahrenheit.Click += btnToFahrenheit_Click;
            // 
            // btnToCelsius
            // 
            btnToCelsius.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnToCelsius.Location = new Point(552, 392);
            btnToCelsius.Name = "btnToCelsius";
            btnToCelsius.Size = new Size(169, 87);
            btnToCelsius.TabIndex = 3;
            btnToCelsius.Text = "Convert to Celsius";
            btnToCelsius.UseVisualStyleBackColor = true;
            btnToCelsius.Click += btnToCelsius_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(424, 239);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(225, 38);
            lblResult.TabIndex = 4;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(309, 537);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 17;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_14
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 657);
            Controls.Add(BackMenubtn);
            Controls.Add(lblResult);
            Controls.Add(btnToCelsius);
            Controls.Add(btnToFahrenheit);
            Controls.Add(txtTemp);
            Controls.Add(label1);
            Name = "A_14";
            Text = "A_14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTemp;
        private Button btnToFahrenheit;
        private Button btnToCelsius;
        private Label lblResult;
        private Button BackMenubtn;
    }
}