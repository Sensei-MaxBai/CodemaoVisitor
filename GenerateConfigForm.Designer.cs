using System.ComponentModel;

namespace CodemaoVisitor
{
    partial class GenerateConfigForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
	        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateConfigForm));
	        this.labTip = new System.Windows.Forms.Label();
	        this.btnConfirm = new System.Windows.Forms.Button();
	        this.dgvProperties = new System.Windows.Forms.DataGridView();
	        ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
	        this.SuspendLayout();
	        // 
	        // labTip
	        // 
	        this.labTip.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.labTip.Location = new System.Drawing.Point(43, 25);
	        this.labTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
	        this.labTip.Name = "labTip";
	        this.labTip.Size = new System.Drawing.Size(750, 83);
	        this.labTip.TabIndex = 0;
	        this.labTip.Text = "将所有值赋好后，点击确定。";
	        // 
	        // btnConfirm
	        // 
	        this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.btnConfirm.Location = new System.Drawing.Point(391, 589);
	        this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
	        this.btnConfirm.Name = "btnConfirm";
	        this.btnConfirm.Size = new System.Drawing.Size(440, 99);
	        this.btnConfirm.TabIndex = 1;
	        this.btnConfirm.Text = "确定";
	        this.btnConfirm.UseVisualStyleBackColor = true;
	        this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
	        // 
	        // dgvProperties
	        // 
	        this.dgvProperties.AllowUserToAddRows = false;
	        this.dgvProperties.AllowUserToDeleteRows = false;
	        this.dgvProperties.AllowUserToResizeColumns = false;
	        this.dgvProperties.AllowUserToResizeRows = false;
	        this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	        this.dgvProperties.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
	        this.dgvProperties.Location = new System.Drawing.Point(43, 85);
	        this.dgvProperties.Margin = new System.Windows.Forms.Padding(4);
	        this.dgvProperties.Name = "dgvProperties";
	        this.dgvProperties.RowHeadersVisible = false;
	        this.dgvProperties.RowTemplate.Height = 30;
	        this.dgvProperties.Size = new System.Drawing.Size(1106, 472);
	        this.dgvProperties.TabIndex = 2;
	        // 
	        // GenerateConfigForm
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.ClientSize = new System.Drawing.Size(1195, 725);
	        this.Controls.Add(this.dgvProperties);
	        this.Controls.Add(this.btnConfirm);
	        this.Controls.Add(this.labTip);
	        this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
	        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
	        this.Margin = new System.Windows.Forms.Padding(4);
	        this.MaximizeBox = false;
	        this.MinimizeBox = false;
	        this.Name = "GenerateConfigForm";
	        this.Text = "配置文本";
	        this.Load += new System.EventHandler(this.GenerateConfig_Load);
	        ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
	        this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvProperties;

        private System.Windows.Forms.Button btnConfirm;

        private System.Windows.Forms.Label labTip;

        #endregion
    }
}