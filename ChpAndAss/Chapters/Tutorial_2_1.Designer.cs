namespace ChpAndAss.Chapters
{
    partial class Tutorial_2_1
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
            Displaybtn = new Button();
            SuspendLayout();
            // 
            // Displaybtn
            // 
            Displaybtn.BackColor = Color.LightSkyBlue;
            Displaybtn.Location = new Point(255, 185);
            Displaybtn.Name = "Displaybtn";
            Displaybtn.Size = new Size(252, 92);
            Displaybtn.TabIndex = 0;
            Displaybtn.Text = "Display Message";
            Displaybtn.UseVisualStyleBackColor = false;
            Displaybtn.Click += Displaybtn_Click;
            // 
            // Tutorial_2_1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Displaybtn);
            Name = "Tutorial_2_1";
            Text = "Tutorial_2_1";
            ResumeLayout(false);
        }

        #endregion

        private Button Displaybtn;
    }
}