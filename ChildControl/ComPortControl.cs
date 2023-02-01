using AutoRenderingWorkingStandard.Modules;
using System;
using System.IO;
using System.Windows.Forms;

namespace AutoRenderingWorkingStandard.ChildControl
{
    public partial class ComPortControl : UserControl
    {
        public ComPortControl()
        {
            InitializeComponent();
        }

        private void ComPortControl_Load(object sender, EventArgs e)
        {


            string path0 = Environment.CurrentDirectory;
            string path1 = $"{path0}\\{Param.Setting}";
            if (!Directory.Exists(path1))
            {
                Directory.CreateDirectory(path1);
            }
           
           
            COMPort();

            LoadSettingfile();
        }

        private void COMPort()
        {
            for (int i = 1; i < 20; i++)
            {
                string str = string.Format("COM{0}", i);
                CmbCom.Items.Add(str);
            }
            CmbCom.SelectedIndex = 0;
            string[] baudrate = new string[] { "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600" };
            string[] parity = new string[] { "None", "Even", "Odd" };
            string[] lenght = new string[] { "7", "8", "9" };
            string[] stopbit = new string[] { "1", "1.5", "2" };
            CmbBaudRate.DataSource = baudrate;
            CmbParity.DataSource = parity;
            CmbDatalength.DataSource = lenght;
            CmbStopBit.DataSource = stopbit;
        }
        private void LoadSettingfile()
        {
            string path = $"{Environment.CurrentDirectory}\\{Param.Setting}\\port.txt";

            if (File.Exists(path))
            {
                string data = File.ReadAllText(path);
                string[] parts = data.Split(',');
                if (parts.Length == 5)
                {
                    string comport = parts[0];
                    string baudrate = parts[1];
                    string parity = parts[2];
                    string dataBits = parts[3];
                    string stopbit = parts[4];

                    CmbCom.SelectedItem = comport;


                    CmbBaudRate.SelectedItem = baudrate;
                    CmbParity.SelectedItem = parity;
                    CmbDatalength.SelectedItem = dataBits;
                    CmbStopBit.SelectedItem = stopbit;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string setting = string.Format("{0},{1},{2},{3},{4}", CmbCom.SelectedItem, CmbBaudRate.SelectedItem, CmbParity.SelectedItem,
                   CmbDatalength.SelectedItem, CmbStopBit.SelectedItem);

                string path = $"{Environment.CurrentDirectory}\\{Param.Setting}\\port.txt";

                File.WriteAllText(path, setting);
                MessageBox.Show("Save Communication port setting Completed","Info" , MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Save Communication port setting Error, try it again", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LoadSettingfile();
        }
    }
}
