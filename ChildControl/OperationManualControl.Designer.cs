namespace AutoRenderingWorkingStandard.ChildControl
{
    partial class OperationManualControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInstuction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Help";
            // 
            // BtnInstuction
            // 
            this.BtnInstuction.Location = new System.Drawing.Point(21, 97);
            this.BtnInstuction.Name = "BtnInstuction";
            this.BtnInstuction.Size = new System.Drawing.Size(90, 31);
            this.BtnInstuction.TabIndex = 1;
            this.BtnInstuction.Text = "Instruction";
            this.BtnInstuction.UseVisualStyleBackColor = true;
            this.BtnInstuction.Click += new System.EventHandler(this.BtnInstuction_Click);
            // 
            // OperationManualControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnInstuction);
            this.Controls.Add(this.label1);
            this.Name = "OperationManualControl";
            this.Size = new System.Drawing.Size(372, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnInstuction;
    }
}
