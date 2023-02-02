namespace AutoRenderingWorkingStandard.ChildForm
{
    partial class ComPortForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbStopBit = new System.Windows.Forms.ComboBox();
            this.CmbDatalength = new System.Windows.Forms.ComboBox();
            this.CmbParity = new System.Windows.Forms.ComboBox();
            this.CmbBaudRate = new System.Windows.Forms.ComboBox();
            this.CmbCom = new System.Windows.Forms.ComboBox();
            this.BtnReload = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TbTrial = new System.Windows.Forms.TextBox();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CmbStopBit);
            this.panel1.Controls.Add(this.CmbDatalength);
            this.panel1.Controls.Add(this.CmbParity);
            this.panel1.Controls.Add(this.CmbBaudRate);
            this.panel1.Controls.Add(this.CmbCom);
            this.panel1.Controls.Add(this.BtnReload);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(45, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 267);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Communication port for Scanner ";
            // 
            // CmbStopBit
            // 
            this.CmbStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStopBit.FormattingEnabled = true;
            this.CmbStopBit.Location = new System.Drawing.Point(82, 182);
            this.CmbStopBit.Name = "CmbStopBit";
            this.CmbStopBit.Size = new System.Drawing.Size(121, 21);
            this.CmbStopBit.TabIndex = 11;
            // 
            // CmbDatalength
            // 
            this.CmbDatalength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDatalength.FormattingEnabled = true;
            this.CmbDatalength.Location = new System.Drawing.Point(82, 148);
            this.CmbDatalength.Name = "CmbDatalength";
            this.CmbDatalength.Size = new System.Drawing.Size(121, 21);
            this.CmbDatalength.TabIndex = 10;
            // 
            // CmbParity
            // 
            this.CmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbParity.FormattingEnabled = true;
            this.CmbParity.Location = new System.Drawing.Point(82, 114);
            this.CmbParity.Name = "CmbParity";
            this.CmbParity.Size = new System.Drawing.Size(121, 21);
            this.CmbParity.TabIndex = 9;
            // 
            // CmbBaudRate
            // 
            this.CmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBaudRate.FormattingEnabled = true;
            this.CmbBaudRate.Location = new System.Drawing.Point(82, 80);
            this.CmbBaudRate.Name = "CmbBaudRate";
            this.CmbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.CmbBaudRate.TabIndex = 8;
            // 
            // CmbCom
            // 
            this.CmbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCom.FormattingEnabled = true;
            this.CmbCom.Location = new System.Drawing.Point(82, 46);
            this.CmbCom.Name = "CmbCom";
            this.CmbCom.Size = new System.Drawing.Size(121, 21);
            this.CmbCom.TabIndex = 7;
            // 
            // BtnReload
            // 
            this.BtnReload.Location = new System.Drawing.Point(85, 230);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(53, 34);
            this.BtnReload.TabIndex = 6;
            this.BtnReload.Text = "Reload";
            this.BtnReload.UseVisualStyleBackColor = true;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(150, 230);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(53, 34);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stop bit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Board rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TbTrial
            // 
            this.TbTrial.Location = new System.Drawing.Point(45, 328);
            this.TbTrial.Name = "TbTrial";
            this.TbTrial.Size = new System.Drawing.Size(728, 20);
            this.TbTrial.TabIndex = 2;
            // 
            // BtnCopy
            // 
            this.BtnCopy.Location = new System.Drawing.Point(652, 363);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(121, 21);
            this.BtnCopy.TabIndex = 3;
            this.BtnCopy.Text = "copy to clipboard";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Reading message from scanner";
            // 
            // ComPortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.TbTrial);
            this.Controls.Add(this.panel1);
            this.Name = "ComPortForm";
            this.Text = "ComPortForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComPortForm_FormClosing);
            this.Load += new System.EventHandler(this.ComPortForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbStopBit;
        private System.Windows.Forms.ComboBox CmbDatalength;
        private System.Windows.Forms.ComboBox CmbParity;
        private System.Windows.Forms.ComboBox CmbBaudRate;
        private System.Windows.Forms.ComboBox CmbCom;
        private System.Windows.Forms.Button BtnReload;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TbTrial;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Label label7;
    }
}