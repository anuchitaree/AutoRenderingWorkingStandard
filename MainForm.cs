using AutoRenderingWorkingStandard.Models;
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
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"--kiosk D:\WSStore\z353.pdf";
            ProcessStartInfo startInfo = new ProcessStartInfo(path);
            startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            Process.Start("firefox.exe", path);
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {


                using (var db = new WSContext())
                {
                    var test = new WorkingStandard()
                    {
                        Partnumber = "TG123456789",
                        Destination = "abc",
                    };
                    db.WorkingStandards.Add(test);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnBrowse(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = System.IO.Directory.GetCurrentDirectory();

            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.Title = "Browse PDF File";

            openFileDialog1.DefaultExt = "pdf";

            openFileDialog1.ReadOnlyChecked = true;

            openFileDialog1.ShowReadOnly = true;


            openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

            //openFileDialog1.ShowDialog();

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Stock\SourceFiles";

                FileInfo fi = new FileInfo(textBox1.Text);

                var uuid = Guid.NewGuid().ToString();

                string destination = $"{path}//{uuid}.pdf";

                fi.CopyTo(destination, true);

                
                using (var db = new WSContext())
                {




                    var record = new WorkingStandard()
                    {
                        Partnumber = ScanText.Text,
                        Destination = destination,
                    };
                    db.WorkingStandards.Add(record);
                    db.SaveChanges();
                }


            }
            catch (Exception)
            {

                throw;
            }
        }





    }
}
