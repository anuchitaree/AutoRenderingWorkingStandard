namespace AutoRenderingWorkingStandard.ChildControl
{
    partial class SetupControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ScanText = new System.Windows.Forms.RichTextBox();
            this.TbDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCopyTo = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.BtnListWs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(373, 183);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(94, 37);
            this.BtnCancel.TabIndex = 16;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(473, 183);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(96, 37);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(494, 123);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 14;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Scanding text";
            // 
            // ScanText
            // 
            this.ScanText.Location = new System.Drawing.Point(16, 25);
            this.ScanText.Name = "ScanText";
            this.ScanText.Size = new System.Drawing.Size(472, 61);
            this.ScanText.TabIndex = 12;
            this.ScanText.Text = "";
            // 
            // TbDestination
            // 
            this.TbDestination.Location = new System.Drawing.Point(7, 123);
            this.TbDestination.Name = "TbDestination";
            this.TbDestination.Size = new System.Drawing.Size(481, 20);
            this.TbDestination.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Source image file";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ScanText);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnBrowse);
            this.panel1.Controls.Add(this.TbDestination);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 239);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCopyTo);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.DgvList);
            this.panel2.Controls.Add(this.BtnListWs);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(15, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 355);
            this.panel2.TabIndex = 19;
            // 
            // BtnCopyTo
            // 
            this.BtnCopyTo.Location = new System.Drawing.Point(563, 16);
            this.BtnCopyTo.Name = "BtnCopyTo";
            this.BtnCopyTo.Size = new System.Drawing.Size(76, 32);
            this.BtnCopyTo.TabIndex = 4;
            this.BtnCopyTo.Text = "Copy to..";
            this.BtnCopyTo.UseVisualStyleBackColor = true;
            this.BtnCopyTo.Click += new System.EventHandler(this.BtnCopyTo_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(473, 16);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(84, 32);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DgvList
            // 
            this.DgvList.AllowUserToAddRows = false;
            this.DgvList.AllowUserToDeleteRows = false;
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvList.Location = new System.Drawing.Point(24, 82);
            this.DgvList.Name = "DgvList";
            this.DgvList.ReadOnly = true;
            this.DgvList.Size = new System.Drawing.Size(738, 253);
            this.DgvList.TabIndex = 2;
            // 
            // BtnListWs
            // 
            this.BtnListWs.Location = new System.Drawing.Point(362, 16);
            this.BtnListWs.Name = "BtnListWs";
            this.BtnListWs.Size = new System.Drawing.Size(95, 33);
            this.BtnListWs.TabIndex = 1;
            this.BtnListWs.Text = "List up";
            this.BtnListWs.UseVisualStyleBackColor = true;
            this.BtnListWs.Click += new System.EventHandler(this.BtnListWs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Working standard registration history";
            // 
            // SetupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SetupControl";
            this.Size = new System.Drawing.Size(831, 664);
            this.Load += new System.EventHandler(this.SetupControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ScanText;
        private System.Windows.Forms.TextBox TbDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.Button BtnListWs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCopyTo;
    }
}
