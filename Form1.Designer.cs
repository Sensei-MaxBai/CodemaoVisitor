namespace CodemaoVisitor
{
    partial class Form1
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
	        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
	        this.tbxFormatPreview = new System.Windows.Forms.TextBox();
	        this.tbxFilePath = new System.Windows.Forms.TextBox();
	        this.btnFileChoice = new System.Windows.Forms.Button();
	        this.labPreview = new System.Windows.Forms.Label();
	        this.btnResolve = new System.Windows.Forms.Button();
	        this.btnManageDicts = new System.Windows.Forms.Button();
	        this.tbxFinalPreview = new System.Windows.Forms.TextBox();
	        this.btnGenerate = new System.Windows.Forms.Button();
	        this.btnCopy = new System.Windows.Forms.Button();
	        this.cbxAutoCopy = new System.Windows.Forms.CheckBox();
	        this.btnEditFile = new System.Windows.Forms.Button();
	        this.btnRefresh = new System.Windows.Forms.Button();
	        this.btnManageDefaultValues = new System.Windows.Forms.Button();
	        this.SuspendLayout();
	        // 
	        // tbxFormatPreview
	        // 
	        this.tbxFormatPreview.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.tbxFormatPreview.Location = new System.Drawing.Point(42, 149);
	        this.tbxFormatPreview.Margin = new System.Windows.Forms.Padding(4);
	        this.tbxFormatPreview.Multiline = true;
	        this.tbxFormatPreview.Name = "tbxFormatPreview";
	        this.tbxFormatPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
	        this.tbxFormatPreview.Size = new System.Drawing.Size(1285, 353);
	        this.tbxFormatPreview.TabIndex = 0;
	        this.tbxFormatPreview.TextChanged += new System.EventHandler(this.tbxFormatPreview_TextChanged);
	        // 
	        // tbxFilePath
	        // 
	        this.tbxFilePath.BackColor = System.Drawing.SystemColors.InactiveBorder;
	        this.tbxFilePath.Enabled = false;
	        this.tbxFilePath.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.tbxFilePath.Location = new System.Drawing.Point(43, 44);
	        this.tbxFilePath.Margin = new System.Windows.Forms.Padding(4);
	        this.tbxFilePath.Name = "tbxFilePath";
	        this.tbxFilePath.Size = new System.Drawing.Size(912, 37);
	        this.tbxFilePath.TabIndex = 1;
	        // 
	        // btnFileChoice
	        // 
	        this.btnFileChoice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.btnFileChoice.Location = new System.Drawing.Point(962, 35);
	        this.btnFileChoice.Margin = new System.Windows.Forms.Padding(4);
	        this.btnFileChoice.Name = "btnFileChoice";
	        this.btnFileChoice.Size = new System.Drawing.Size(117, 52);
	        this.btnFileChoice.TabIndex = 2;
	        this.btnFileChoice.Text = "选择文件";
	        this.btnFileChoice.UseVisualStyleBackColor = true;
	        this.btnFileChoice.Click += new System.EventHandler(this.btnFileChoice_Click);
	        // 
	        // labPreview
	        // 
	        this.labPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
	        this.labPreview.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.labPreview.Location = new System.Drawing.Point(42, 95);
	        this.labPreview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
	        this.labPreview.Name = "labPreview";
	        this.labPreview.Size = new System.Drawing.Size(187, 45);
	        this.labPreview.TabIndex = 3;
	        this.labPreview.Text = "文本预览";
	        this.labPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
	        // 
	        // btnResolve
	        // 
	        this.btnResolve.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.btnResolve.Location = new System.Drawing.Point(578, 536);
	        this.btnResolve.Margin = new System.Windows.Forms.Padding(4);
	        this.btnResolve.Name = "btnResolve";
	        this.btnResolve.Size = new System.Drawing.Size(235, 69);
	        this.btnResolve.TabIndex = 4;
	        this.btnResolve.Text = "解析";
	        this.btnResolve.UseVisualStyleBackColor = true;
	        this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
	        // 
	        // btnManageDicts
	        // 
	        this.btnManageDicts.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.btnManageDicts.Location = new System.Drawing.Point(309, 536);
	        this.btnManageDicts.Margin = new System.Windows.Forms.Padding(4);
	        this.btnManageDicts.Name = "btnManageDicts";
	        this.btnManageDicts.Size = new System.Drawing.Size(235, 69);
	        this.btnManageDicts.TabIndex = 6;
	        this.btnManageDicts.Text = "管理字典";
	        this.btnManageDicts.UseVisualStyleBackColor = true;
	        this.btnManageDicts.Click += new System.EventHandler(this.btnManageDicts_Click);
	        // 
	        // tbxFinalPreview
	        // 
	        this.tbxFinalPreview.BackColor = System.Drawing.SystemColors.InactiveBorder;
	        this.tbxFinalPreview.Enabled = false;
	        this.tbxFinalPreview.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.tbxFinalPreview.Location = new System.Drawing.Point(43, 731);
	        this.tbxFinalPreview.Margin = new System.Windows.Forms.Padding(4);
	        this.tbxFinalPreview.Multiline = true;
	        this.tbxFinalPreview.Name = "tbxFinalPreview";
	        this.tbxFinalPreview.ReadOnly = true;
	        this.tbxFinalPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
	        this.tbxFinalPreview.Size = new System.Drawing.Size(1285, 569);
	        this.tbxFinalPreview.TabIndex = 7;
	        // 
	        // btnGenerate
	        // 
	        this.btnGenerate.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.btnGenerate.Location = new System.Drawing.Point(845, 536);
	        this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
	        this.btnGenerate.Name = "btnGenerate";
	        this.btnGenerate.Size = new System.Drawing.Size(483, 69);
	        this.btnGenerate.TabIndex = 8;
	        this.btnGenerate.Text = "生成";
	        this.btnGenerate.UseVisualStyleBackColor = true;
	        this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
	        // 
	        // btnCopy
	        // 
	        this.btnCopy.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.btnCopy.Location = new System.Drawing.Point(211, 629);
	        this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
	        this.btnCopy.Name = "btnCopy";
	        this.btnCopy.Size = new System.Drawing.Size(1117, 69);
	        this.btnCopy.TabIndex = 9;
	        this.btnCopy.Text = "复制";
	        this.btnCopy.UseVisualStyleBackColor = true;
	        this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
	        // 
	        // cbxAutoCopy
	        // 
	        this.cbxAutoCopy.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.cbxAutoCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
	        this.cbxAutoCopy.Location = new System.Drawing.Point(42, 627);
	        this.cbxAutoCopy.Margin = new System.Windows.Forms.Padding(4);
	        this.cbxAutoCopy.Name = "cbxAutoCopy";
	        this.cbxAutoCopy.Size = new System.Drawing.Size(149, 71);
	        this.cbxAutoCopy.TabIndex = 10;
	        this.cbxAutoCopy.Text = "自动复制";
	        this.cbxAutoCopy.UseVisualStyleBackColor = true;
	        // 
	        // btnEditFile
	        // 
	        this.btnEditFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.btnEditFile.Location = new System.Drawing.Point(1087, 35);
	        this.btnEditFile.Margin = new System.Windows.Forms.Padding(4);
	        this.btnEditFile.Name = "btnEditFile";
	        this.btnEditFile.Size = new System.Drawing.Size(117, 52);
	        this.btnEditFile.TabIndex = 11;
	        this.btnEditFile.Text = "编辑文件";
	        this.btnEditFile.UseVisualStyleBackColor = true;
	        this.btnEditFile.Click += new System.EventHandler(this.btnEditFile_Click);
	        // 
	        // btnRefresh
	        // 
	        this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.btnRefresh.Location = new System.Drawing.Point(1211, 35);
	        this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
	        this.btnRefresh.Name = "btnRefresh";
	        this.btnRefresh.Size = new System.Drawing.Size(117, 52);
	        this.btnRefresh.TabIndex = 12;
	        this.btnRefresh.Text = "刷新";
	        this.btnRefresh.UseVisualStyleBackColor = true;
	        this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
	        // 
	        // btnManageDefaultValues
	        // 
	        this.btnManageDefaultValues.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.btnManageDefaultValues.Location = new System.Drawing.Point(42, 536);
	        this.btnManageDefaultValues.Margin = new System.Windows.Forms.Padding(4);
	        this.btnManageDefaultValues.Name = "btnManageDefaultValues";
	        this.btnManageDefaultValues.Size = new System.Drawing.Size(235, 69);
	        this.btnManageDefaultValues.TabIndex = 13;
	        this.btnManageDefaultValues.Text = "管理默认值";
	        this.btnManageDefaultValues.UseVisualStyleBackColor = true;
	        this.btnManageDefaultValues.Click += new System.EventHandler(this.btnManageDefaultValues_Click);
	        // 
	        // Form1
	        // 
	        this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
	        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	        this.AutoScroll = true;
	        this.ClientSize = new System.Drawing.Size(1380, 1353);
	        this.Controls.Add(this.btnManageDefaultValues);
	        this.Controls.Add(this.btnRefresh);
	        this.Controls.Add(this.btnEditFile);
	        this.Controls.Add(this.cbxAutoCopy);
	        this.Controls.Add(this.btnCopy);
	        this.Controls.Add(this.btnGenerate);
	        this.Controls.Add(this.tbxFinalPreview);
	        this.Controls.Add(this.btnManageDicts);
	        this.Controls.Add(this.btnResolve);
	        this.Controls.Add(this.labPreview);
	        this.Controls.Add(this.btnFileChoice);
	        this.Controls.Add(this.tbxFilePath);
	        this.Controls.Add(this.tbxFormatPreview);
	        this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
	        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
	        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
	        this.Margin = new System.Windows.Forms.Padding(4);
	        this.MaximizeBox = false;
	        this.Name = "Form1";
	        this.Text = "家长消息格式化生成器";
	        this.Load += new System.EventHandler(this.Form1_Load);
	        this.ResumeLayout(false);
	        this.PerformLayout();
        }

        private System.Windows.Forms.Button btnManageDefaultValues;

        private System.Windows.Forms.Button btnEditFile;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.CheckBox cbxAutoCopy;

        private System.Windows.Forms.Button btnCopy;

        private System.Windows.Forms.Button btnGenerate;

        private System.Windows.Forms.TextBox tbxFinalPreview;

        private System.Windows.Forms.Button btnManageDicts;

        private System.Windows.Forms.Button btnResolve;

        private System.Windows.Forms.Label labPreview;

        private System.Windows.Forms.Button btnFileChoice;

        private System.Windows.Forms.TextBox tbxFilePath;

        private System.Windows.Forms.TextBox tbxFormatPreview;

        #endregion
    }
}