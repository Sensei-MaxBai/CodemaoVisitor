using System.ComponentModel;

namespace CodemaoVisitor
{
    partial class ConfigWidget
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labKey = new System.Windows.Forms.Label();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labKey
            // 
            this.labKey.Location = new System.Drawing.Point(14, 6);
            this.labKey.Name = "labKey";
            this.labKey.Size = new System.Drawing.Size(136, 29);
            this.labKey.TabIndex = 0;
            this.labKey.Text = "KEY";
            this.labKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxValue
            // 
            this.tbxValue.Location = new System.Drawing.Point(87, 6);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(500, 28);
            this.tbxValue.TabIndex = 1;
            // 
            // ConfigWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxValue);
            this.Controls.Add(this.labKey);
            this.Name = "ConfigWidget";
            this.Size = new System.Drawing.Size(601, 38);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbxValue;

        private System.Windows.Forms.Label labKey;

        #endregion
    }
}