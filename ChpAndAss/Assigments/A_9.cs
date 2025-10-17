using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChpAndAss.Assigments
{
    public partial class A_9 : Form
    {
        public A_9()
        {
            InitializeComponent();
        }



        private void Showstartbutton_Click(object sender, EventArgs e)
        {
            labelBetelgeuse.Visible = true;
            labelMeissa.Visible = true;
            labelAlnitak.Visible = true;
            labelAlnilan.Visible = true;
            labelMintaka.Visible = true;
            labelSaiph.Visible = true;
            labelRigel.Visible = true;
        }

        private void Hidestartbutton_Click(object sender, EventArgs e)
        {
            labelBetelgeuse.Visible = false;
            labelMeissa.Visible = false;
            labelAlnitak.Visible = false;
            labelAlnilan.Visible = false;
            labelMintaka.Visible = false;
            labelSaiph.Visible = false;
            labelRigel.Visible = false;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
