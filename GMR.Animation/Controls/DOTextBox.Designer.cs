using System;

namespace MRG1.SuperDataControls
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class DesignerGeneratedAttribute : Attribute { }
    [DesignerGenerated]
    partial class DOTextBox : System.Windows.Forms.UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        [System.Diagnostics.DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTextBox
            // 
            this.txtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTextBox.Location = new System.Drawing.Point(6, 5);
            this.txtTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(245, 22);
            this.txtTextBox.TabIndex = 0;
            this.txtTextBox.TextChanged += new System.EventHandler(this.txtTextBox_TextChanged);
            this.txtTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTextBox_KeyDown);
            this.txtTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.txtTextBox_Validating);
            this.txtTextBox.Validated += new System.EventHandler(this.txtTextBox_Validated);
            // 
            // DOTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtTextBox);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "DOTextBox";
            this.Size = new System.Drawing.Size(264, 25);
            this.Resize += new System.EventHandler(this.DOTextBox_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtTextBox;
    }
}
