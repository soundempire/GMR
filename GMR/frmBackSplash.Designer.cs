namespace MRG1
{
    partial class frmBackSplash
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
            this.imgGMRLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgGMRLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgGMRLogo
            // 
            this.imgGMRLogo.Image = global::MRG1.Properties.Resources.GMR;
            this.imgGMRLogo.Location = new System.Drawing.Point(452, 224);
            this.imgGMRLogo.Name = "imgGMRLogo";
            this.imgGMRLogo.Size = new System.Drawing.Size(197, 195);
            this.imgGMRLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGMRLogo.TabIndex = 0;
            this.imgGMRLogo.TabStop = false;
            // 
            // frmBackSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 699);
            this.Controls.Add(this.imgGMRLogo);
            this.Name = "frmBackSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GMR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBackSplash_FormClosing);
            this.Load += new System.EventHandler(this.frmBackSplash_Load);
            this.Shown += new System.EventHandler(this.frmBackSplash_Shown);
            this.Resize += new System.EventHandler(this.frmBackSplash_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.imgGMRLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgGMRLogo;
    }
}