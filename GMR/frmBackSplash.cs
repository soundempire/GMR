using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRG1
{
    public partial class frmBackSplash : Form
    {
        public frmBackSplash()
        {
            InitializeComponent();
        }

        private void frmBackSplash_Load(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.White;
            Icon = Common.GetIconFromLib("GMRLogo.ico"); 
        }

        private void frmBackSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void frmBackSplash_Resize(object sender, EventArgs e)
        {
            FitStuff();
        }
        private void FitStuff()
        {
            imgGMRLogo.Left = (this.ClientSize.Width - imgGMRLogo.Width) / 2;
            imgGMRLogo.Top = (this.ClientSize.Height/2) - imgGMRLogo.Height;
        }

        private void frmBackSplash_Shown(object sender, EventArgs e)
        {
            FitStuff();
        }
    }      
}
