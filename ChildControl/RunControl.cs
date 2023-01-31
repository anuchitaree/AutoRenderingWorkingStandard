using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRenderingWorkingStandard.ChildControl
{
    public partial class RunControl : UserControl
    {
        public RunControl()
        {
            InitializeComponent();
        }

        private void BtnTest1_Click(object sender, EventArgs e)
        {
            string path = @"--kiosk D:\WSStore\z353.pdf";
            ProcessStartInfo startInfo = new ProcessStartInfo(path);
            startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            Process.Start("firefox.exe", path);
        }

        private void BtnTest2_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process proc in processes)
            {
                if (proc.ProcessName == "firefox")
                {
                    proc.Kill();
                    //proc.CloseMainWindow();
                }
            }
        }
    }
}
