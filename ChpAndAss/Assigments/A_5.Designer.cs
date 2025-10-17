namespace ChpAndAss.Assigments
{
    partial class A_5
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
            btnSinister = new Button();
            btnDexter = new Button();
            btnMedium = new Button();
            lblTranslation = new Label();
            BackMenubtn = new Button();
            SuspendLayout();
            // 
            // btnSinister
            // 
            btnSinister.BackColor = Color.LightPink;
            btnSinister.Font = new Font("Calibri", 12F);
            btnSinister.Location = new Point(147, 333);
            btnSinister.Name = "btnSinister";
            btnSinister.Size = new Size(183, 111);
            btnSinister.TabIndex = 0;
            btnSinister.Text = "Sinister";
            btnSinister.UseVisualStyleBackColor = false;
            btnSinister.Click += btnSinister_Click;
            // 
            // btnDexter
            // 
            btnDexter.BackColor = Color.LightPink;
            btnDexter.Font = new Font("Calibri", 12F);
            btnDexter.Location = new Point(370, 333);
            btnDexter.Name = "btnDexter";
            btnDexter.Size = new Size(178, 111);
            btnDexter.TabIndex = 1;
            btnDexter.Text = "Dexter";
            btnDexter.UseVisualStyleBackColor = false;
            btnDexter.Click += btnDexter_Click;
            // 
            // btnMedium
            // 
            btnMedium.BackColor = Color.LightPink;
            btnMedium.Font = new Font("Calibri", 12F);
            btnMedium.Location = new Point(607, 337);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(165, 102);
            btnMedium.TabIndex = 2;
            btnMedium.Text = "Medium";
            btnMedium.UseVisualStyleBackColor = false;
            btnMedium.Click += btnMedium_Click;
            // 
            // lblTranslation
            // 
            lblTranslation.BorderStyle = BorderStyle.FixedSingle;
            lblTranslation.Font = new Font("Cambria", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTranslation.Location = new Point(259, 141);
            lblTranslation.Name = "lblTranslation";
            lblTranslation.Size = new Size(344, 104);
            lblTranslation.TabIndex = 3;
            lblTranslation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            BackMenubtn.Font = new Font("Nirmala UI", 15F);
            BackMenubtn.ImeMode = ImeMode.NoControl;
            BackMenubtn.Location = new Point(244, 543);
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.Size = new Size(385, 91);
            BackMenubtn.TabIndex = 8;
            BackMenubtn.Text = "Back To Menu";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(882, 708);
            Controls.Add(BackMenubtn);
            Controls.Add(lblTranslation);
            Controls.Add(btnMedium);
            Controls.Add(btnDexter);
            Controls.Add(btnSinister);
            Name = "A_5";
            Text = "A_5";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSinister;
        private Button btnDexter;
        private Button btnMedium;
        private Label lblTranslation;
        private Button BackMenubtn;
    }
}