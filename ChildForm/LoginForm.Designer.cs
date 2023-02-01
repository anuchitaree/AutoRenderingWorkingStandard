namespace AutoRenderingWorkingStandard.ChildForm
{
    partial class LoginForm
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
            this.BtnChangePassword = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnBuildAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangePassword.Location = new System.Drawing.Point(42, 440);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(384, 72);
            this.BtnChangePassword.TabIndex = 22;
            this.BtnChangePassword.Text = "Change Password";
            this.BtnChangePassword.UseVisualStyleBackColor = true;
            this.BtnChangePassword.Visible = false;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Red;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnExit.Location = new System.Drawing.Point(227, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(59, 33);
            this.BtnExit.TabIndex = 19;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtUserID
            // 
            this.TxtUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.TxtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserID.ForeColor = System.Drawing.Color.White;
            this.TxtUserID.Location = new System.Drawing.Point(68, 69);
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.Size = new System.Drawing.Size(149, 28);
            this.TxtUserID.TabIndex = 0;
            this.TxtUserID.TabStop = false;
            this.TxtUserID.Text = "User";
            this.TxtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.label2.Location = new System.Drawing.Point(99, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Log in";
            // 
            // TxtPassCode
            // 
            this.TxtPassCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.TxtPassCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassCode.ForeColor = System.Drawing.Color.White;
            this.TxtPassCode.Location = new System.Drawing.Point(62, 143);
            this.TxtPassCode.Name = "TxtPassCode";
            this.TxtPassCode.Size = new System.Drawing.Size(149, 24);
            this.TxtPassCode.TabIndex = 7;
            this.TxtPassCode.Text = "Password";
            this.TxtPassCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassCode_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(21, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 1);
            this.panel1.TabIndex = 8;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(166)))), ((int)(((byte)(209)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(3, 216);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(283, 63);
            this.BtnLogin.TabIndex = 10;
            this.BtnLogin.Text = "Log in";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.BtnChangePassword);
            this.panel3.Controls.Add(this.BtnExit);
            this.panel3.Controls.Add(this.BtnBuildAccount);
            this.panel3.Controls.Add(this.TxtUserID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.TxtPassCode);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.BtnLogin);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(7, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 282);
            this.panel3.TabIndex = 20;
            // 
            // BtnBuildAccount
            // 
            this.BtnBuildAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuildAccount.Location = new System.Drawing.Point(42, 349);
            this.BtnBuildAccount.Name = "BtnBuildAccount";
            this.BtnBuildAccount.Size = new System.Drawing.Size(384, 72);
            this.BtnBuildAccount.TabIndex = 17;
            this.BtnBuildAccount.Text = "Create you account";
            this.BtnBuildAccount.UseVisualStyleBackColor = true;
            this.BtnBuildAccount.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(21, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 1);
            this.panel2.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(305, 301);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnChangePassword;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBuildAccount;
    }
}