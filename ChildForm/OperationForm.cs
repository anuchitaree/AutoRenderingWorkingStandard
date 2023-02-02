using AutoRenderingWorkingStandard.Models;
using AutoRenderingWorkingStandard.Modules;
using AutoRenderingWorkingStandard.Modules.Initial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRenderingWorkingStandard.ChildForm
{
    public partial class OperationForm : Form
    {
        private static readonly SerialPort serialPort = new SerialPort();
        private static string ReadingText;
        private static int Counter;


        public OperationForm()
        {
            InitializeComponent();
        }

        private void OperationForm_Load(object sender, EventArgs e)
        {
            Loadpattern();

            OpenPort();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ReadingText != null && ReadingText.Length == Param.Patterns.TotalLength)
            {
                ReadingText = ReadingText.Substring(Param.Patterns.Start, Param.Patterns.Length);
                AsyncInsertTable(ReadingText); //aaaaaaaaaa

            }
            ReadingText = null;
        }
        private void OperationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serial_Port.Close(serialPort);
        }
        //=========================================//
        #region SubProgram
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

                    int maxRetries = 3;
                    const int sleepTimeInMs = 500;
                    while (maxRetries > 0)
                    {
                        try
                        {
                            if (serialPort != null)
                            {

                                if (serialPort.IsOpen)
                                {
                                    serialPort.Close();
                                }
                            }
                            serialPort.PortName = comport;
                            serialPort.BaudRate = Convert.ToInt32(BaudRate);
                            serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), parity);
                            serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopbit);
                            serialPort.DataBits = Convert.ToInt16(DataBits);

                            serialPort.Handshake = Handshake.None;

                            if (!serialPort.IsOpen)
                                serialPort.Open();

                            if (serialPort.IsOpen)
                            {
                                serialPort.DiscardInBuffer();
                                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                                timer1.Enabled = true;

                                break;
                            }
                        }

                        catch (UnauthorizedAccessException)
                        {
                            maxRetries--;
                            Thread.Sleep(sleepTimeInMs);
                        }
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

        private async void AsyncInsertTable(string partnumber)
        {
           
            try
            {
                using (var db = new WSContext())
                {
                    var existData = await db.WorkingStandards
                        .Where(x => x.Partnumber == partnumber).FirstOrDefaultAsync();

                    if (existData != null)
                    {
                        string path = existData.Destination;

                        PictureBox1.Image = Image.FromFile(path);
                    }
                }
            }
            catch
            {

            }


        }

        #endregion

       
    }
}
