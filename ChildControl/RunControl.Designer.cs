namespace AutoRenderingWorkingStandard.ChildControl
{
    partial class RunControl
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
            this.BtnTest2 = new System.Windows.Forms.Button();
            this.BtnTest1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTest2
            // 
            this.BtnTest2.Location = new System.Drawing.Point(217, 125);
            this.BtnTest2.Name = "BtnTest2";
            this.BtnTest2.Size = new System.Drawing.Size(75, 23);
            this.BtnTest2.TabIndex = 3;
            this.BtnTest2.Text = "button2";
            this.BtnTest2.UseVisualStyleBackColor = true;
            this.BtnTest2.Click += new System.EventHandler(this.BtnTest2_Click);
            // 
            // BtnTest1
            // 
            this.BtnTest1.Location = new System.Drawing.Point(103, 140);
            this.BtnTest1.Name = "BtnTest1";
            this.BtnTest1.Size = new System.Drawing.Size(75, 23);
            this.BtnTest1.TabIndex = 2;
            this.BtnTest1.Text = "Run app";
            this.BtnTest1.UseVisualStyleBackColor = true;
            this.BtnTest1.Click += new System.EventHandler(this.BtnTest1_Click);
            // 
            // RunControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnTest2);
            this.Controls.Add(this.BtnTest1);
            this.Name = "RunControl";
            this.Size = new System.Drawing.Size(394, 289);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTest2;
        private System.Windows.Forms.Button BtnTest1;
    }
}
