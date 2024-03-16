using System.ComponentModel;

namespace CodemaoVisitor
{
    partial class PropertyCollection
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
            this.labPropertyName = new System.Windows.Forms.Label();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labPropertyName
            // 
            this.labPropertyName.Location = new System.Drawing.Point(0, 0);
            this.labPropertyName.Name = "labPropertyName";
            this.labPropertyName.Size = new System.Drawing.Size(100, 23);
            this.labPropertyName.TabIndex = 0;
            this.labPropertyName.Text = "none";
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(0, 0);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(100, 28);
            this.tbxInput.TabIndex = 0;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox tbxInput;

        private System.Windows.Forms.Label labPropertyName;

        #endregion
    }
}