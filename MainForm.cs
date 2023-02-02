using AutoRenderingWorkingStandard.ChildControl;
using AutoRenderingWorkingStandard.ChildForm;
using System;
using System.Threading;
using System.Windows.Forms;

namespace AutoRenderingWorkingStandard
{
    public partial class MainForm : Form
    {


        private Form activeForm = null;

        readonly CancellationTokenSource[] cts = new CancellationTokenSource[3];

        public MainForm()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }




        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void operationManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();

            var ctrl = new OperationManualControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();

            var ctrl = new AboutControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();

            CloseOpenChildForm(new OperationForm());

        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();

            var ctrl = new LicenseControl();
            this.pnlForm.Controls.Add(ctrl);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //LoginForm frm = new LoginForm();
            //frm.LoginSuccess += new EventHandler(Login_LoginSuccess);
            //frm.ExitApplication += new EventHandler(Login_ExitApplication);
            //frm.Show();



        }
        private void Login_LoginSuccess(object sender, EventArgs e)
        {

        }
        private void Login_ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();

            var ctrl = new SetupControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void cOMPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();

            CloseOpenChildForm(new ComPortForm());


        }

        private void receivePatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();

            var ctrl = new PatternTrainingControl();
            this.pnlForm.Controls.Add(ctrl);
        }
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenChildForm(new TestScannerForm());
        }


        //===================//
        #region Sub Program




        private void CloseChildForm()
        {
            this.pnlForm.Controls.Clear();

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "MainForm")
                    Application.OpenForms[i].Close();
            }
        }


        private void CloseOpenChildForm(Form switchForm)
        {
            //Close child form

            this.pnlForm.Controls.Clear();

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "MainForm")
                    Application.OpenForms[i].Close();
            }

            try
            {
                if (activeForm != null)
                {
                    this.pnlForm.Controls.Remove(switchForm);
                    activeForm.Close();
                }

                activeForm = switchForm;
                switchForm.TopLevel = false;
                switchForm.FormBorderStyle = FormBorderStyle.None;
                switchForm.Dock = DockStyle.Fill;

                this.pnlForm.Controls.Add(switchForm);
                this.pnlForm.Tag = switchForm;

                switchForm.BringToFront();
                switchForm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error message : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

    }
}
