using AutoRenderingWorkingStandard.ChildControl;
using AutoRenderingWorkingStandard.Models;
using AutoRenderingWorkingStandard.Modules;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AutoRenderingWorkingStandard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

       

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void operationManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();

            var ctrl = new OperationManualControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();

            var ctrl = new AboutControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();

            var ctrl = new RunControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void workingStandardRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();

            var ctrl = new SetupControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void cOMPortSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();

            var ctrl = new ComPortControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();

            var ctrl = new BackGroundControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();

            var ctrl = new LicenseControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void patternTraningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();

            var ctrl = new PatternTrainingControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitialSetup();
        }
        private void InitialSetup()
        {
            //Keepfile.SerialSetting();
            //PortSettingDefault();
            //string file1 = string.Format("{0}\\PortSetting1.txt", Parameter.PortSetting);
            //string file2 = string.Format("{0}\\PortSetting2.txt", Parameter.PortSetting);
            //string file3 = string.Format("{0}\\PortSetting3.txt", Parameter.PortSetting);
            //string file4 = string.Format("{0}\\PortSetting4.txt", Parameter.PortSetting);
            //LoadSettingAndOpenSerialPort(1, file1, serialPort1);
            //LoadSettingAndOpenSerialPort(2, file2, serialPort2);
            //LoadSettingAndOpenSerialPort(3, file3, serialPort3);
            //LoadSettingAndOpenSerialPort(4, file4, serialPort4);

            Loadpattern();
        }

        private void Loadpattern()
        {
            string path = string.Format("{0}\\pattern.txt", Param.PortSetting);
            string data = File.ReadAllText(path);
            string[] parts = data.Split(',');
            if (parts.Length > 3)
            {
                Param.Patterns.TotalLength = int.Parse(parts[0]);
                Param.Patterns.Start = Convert.ToInt32(parts[1]);
                Param.Patterns.Length = Convert.ToInt32(parts[2]);
            }
        }
    }
}
