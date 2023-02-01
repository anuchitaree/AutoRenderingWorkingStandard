using AutoRenderingWorkingStandard.ChildControl;
using AutoRenderingWorkingStandard.Models;
using AutoRenderingWorkingStandard.Modules;
using AutoRenderingWorkingStandard.Modules.Initial;
using System;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace AutoRenderingWorkingStandard
{
    public partial class MainForm : Form
    {
        private static readonly SerialPort serialPort = new SerialPort();
        private static string ReadingText;
        private static int Counter;

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

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //LoginForm frm = new LoginForm();
            //frm.LoginSuccess += new EventHandler(Login_LoginSuccess);
            //frm.ExitApplication += new EventHandler(Login_ExitApplication);
            //frm.Show();

            InitialSetup();
           
        }
        private void Login_LoginSuccess(object sender, EventArgs e)
        {

        }
        private void Login_ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void InitialSetup()
        {
            //Serial_Port.Init();
            //OpenPort();
            //Loadpattern();
        }

        private void Loadpattern()
        {
            string env = Environment.CurrentDirectory;
            string path = $"{env}\\Setting\\pattern.txt";
            if (!File.Exists(path))
            {
                MessageBox.Show("Please Setup pattern first, SETUP -> PATTERN ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string data = File.ReadAllText(path);

            string[] parts = data.Split(',');
            if (parts.Length > 5)
            {
                Param.Patterns.TotalLength = int.Parse(parts[0]);
                Param.Patterns.Start = Convert.ToInt32(parts[1]);
                Param.Patterns.Length = Convert.ToInt32(parts[2]);
            }
        }




        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();

            var ctrl = new SetupControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void cOMPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();

            var ctrl = new ComPortControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void receivePatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();

            var ctrl = new PatternTrainingControl();
            this.pnlForm.Controls.Add(ctrl);
        }

        private void OpenPort()
        {
            try
            {
                string directory = $"{Environment.CurrentDirectory}\\{Param.Setting}\\port.txt";
                string setting = File.ReadAllText(directory);

                string[] parts = setting.Split(',');
                if (parts.Length == 5)
                {
                    string comport = parts[0];
                    string BaudRate = parts[1];
                    string DataBits = parts[3];
                    string stopbit = parts[4];
                    string parity = parts[2];

                    serialPort.PortName = comport;
                    serialPort.BaudRate = Convert.ToInt32(BaudRate);
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), parity);
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopbit);
                    serialPort.DataBits = Convert.ToInt16(DataBits);

                    serialPort.Handshake = Handshake.None;
                    int maxRetries = 3;
                    const int sleepTimeInMs = 500;
                    while (maxRetries > 0)
                    {
                        try
                        {
                            serialPort.Open();
                            if (serialPort.IsOpen)
                            {
                                serialPort.DiscardInBuffer();
                                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                                timer1.Enabled = true;
                                //LbSetting1.Text = string.Format("{0} : {1},{2},{3},{4},{5}", mode, comport, BaudRate, DataBits, stopbit, parity);

                                break;
                            }
                        }
                        //catch (UnauthorizedAccessException)
                        //{
                        //    maxRetries--;
                        //    Thread.Sleep(sleepTimeInMs);
                        //}
                        catch (Exception exception)
                        {
                            maxRetries--;
                            Console.WriteLine(exception.Message);
                        }
                    }

                    if (maxRetries != 3)
                    {
                        Console.WriteLine("maxRetries:{0}", maxRetries);
                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            ReadingText = sp.ReadExisting().Trim('\r');
            Counter++;
            serialPort.DiscardInBuffer();
            Console.WriteLine("Data Received Port 1:{0} : {1}", Counter, ReadingText);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (ReadingText.Length == Param.Patterns.TotalLength)
            {
                ReadingText = ReadingText.Substring(Param.Patterns.Start, Param.Patterns.Length);
                AsyncInsertTable(ReadingText);
            }
            //Message1.Text = String.Format("Count: {0} ,PartNUmber: {1}", Counter1, ReadingText1);
            ReadingText = null;

        }

        private async void AsyncInsertTable(string partnumber)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            try
            {
                using (var db = new WSContext())
                {
                    var existData = await db.WorkingStandards
                        .Where(x => x.Partnumber == partnumber).FirstOrDefaultAsync();

                    if (existData != null)
                    {
                        string path = existData.Destination;

                       
                    }
                }
            }
            catch
            {

            }


        }
    }
}
