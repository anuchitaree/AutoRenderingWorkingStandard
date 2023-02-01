using AutoRenderingWorkingStandard.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRenderingWorkingStandard.ChildForm
{
    public partial class LoginForm : Form
    {
        public event EventHandler LoginSuccess;
        public event EventHandler ExitApplication;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

           

        }

       
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            Initial_loginLoader();
        }

        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtPassCode.Focus();
                SubtxtPassCode();
               
            }
        }

        private void SubtxtPassCode()
        {
            TxtPassCode.Clear();
            TxtPassCode.PasswordChar = 'x';
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            TxtPassCode.ForeColor = Color.FromArgb(78, 184, 206);


            panel1.BackColor = Color.WhiteSmoke;
            TxtUserID.ForeColor = Color.WhiteSmoke;
        }
        private void TxtPassCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {

                    Loging();
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static bool VerifyPassword(string hash, string userID,string password)
        {
            string hashed = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{userID}.{password}"));

            return hash == hashed;
        }

        private void Initial_loginLoader()
        {
            this.TopMost = true;


            if (!String.IsNullOrEmpty(TxtUserID.Text))
            {
                TxtUserID.SelectionStart = 0;
                TxtUserID.SelectionLength = TxtUserID.Text.Length;
            }

            TxtUserID.Select();
            this.ActiveControl = TxtUserID;
            TxtUserID.Focus();


        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.ExitApplication?.Invoke(this, EventArgs.Empty);

            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Loging();
        }
        private void Loging()
        {
            using (var db = new WSContext())
            {
                var existData = db.Accounts.Where(x => x.UserID == TxtUserID.Text.Trim())
                     .FirstOrDefault();
                if (existData == null)
                {
                    MessageBox.Show("No User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string hash = existData.HashPassword;

                if (VerifyPassword(hash, TxtUserID.Text.Trim(), TxtPassCode.Text))
                {
                    this.LoginSuccess?.Invoke(this, EventArgs.Empty);

                    this.Close();
                }

            }
        }
    }
}
