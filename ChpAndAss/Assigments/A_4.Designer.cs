namespace ChpAndAss.Assigments
{
    partial class A_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_4));
            CardFacebtn = new Button();
            Cardbackbtn = new Button();
            cardFacePictureBox = new PictureBox();
            Cardbackpicture = new PictureBox();
            BackMenubtn = new Button();
            ((System.ComponentModel.ISupportInitialize)cardFacePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cardbackpicture).BeginInit();
            SuspendLayout();
            // 
            // CardFacebtn
            // 
            CardFacebtn.BackColor = Color.Purple;
            resources.ApplyResources(CardFacebtn, "CardFacebtn");
            CardFacebtn.ForeColor = SystemColors.ButtonHighlight;
            CardFacebtn.Name = "CardFacebtn";
            CardFacebtn.UseVisualStyleBackColor = false;
            CardFacebtn.Click += CardFacebtn_Click;
            // 
            // Cardbackbtn
            // 
            Cardbackbtn.BackColor = Color.Purple;
            resources.ApplyResources(Cardbackbtn, "Cardbackbtn");
            Cardbackbtn.ForeColor = SystemColors.ButtonHighlight;
            Cardbackbtn.Name = "Cardbackbtn";
            Cardbackbtn.UseVisualStyleBackColor = false;
            Cardbackbtn.Click += Cardbackbtn_Click;
            // 
            // cardFacePictureBox
            // 
            cardFacePictureBox.Image = Properties.Resources.T_face;
            resources.ApplyResources(cardFacePictureBox, "cardFacePictureBox");
            cardFacePictureBox.Name = "cardFacePictureBox";
            cardFacePictureBox.TabStop = false;
            // 
            // Cardbackpicture
            // 
            Cardbackpicture.Image = Properties.Resources.T_back;
            resources.ApplyResources(Cardbackpicture, "Cardbackpicture");
            Cardbackpicture.Name = "Cardbackpicture";
            Cardbackpicture.TabStop = false;
            // 
            // BackMenubtn
            // 
            BackMenubtn.BackColor = Color.Violet;
            resources.ApplyResources(BackMenubtn, "BackMenubtn");
            BackMenubtn.Name = "BackMenubtn";
            BackMenubtn.UseVisualStyleBackColor = false;
            BackMenubtn.Click += BackMenubtn_Click;
            // 
            // A_4
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(BackMenubtn);
            Controls.Add(Cardbackpicture);
            Controls.Add(cardFacePictureBox);
            Controls.Add(Cardbackbtn);
            Controls.Add(CardFacebtn);
            Name = "A_4";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)cardFacePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cardbackpicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CardFacebtn;
        private Button Cardbackbtn;
        private PictureBox cardFacePictureBox;
        private PictureBox Cardbackpicture;
        private Button BackMenubtn;
    }
}