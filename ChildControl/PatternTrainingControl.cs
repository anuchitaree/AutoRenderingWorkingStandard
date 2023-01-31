using AutoRenderingWorkingStandard.Modules;
using System;
using System.IO;
using System.Windows.Forms;

namespace AutoRenderingWorkingStandard.ChildControl
{
    public partial class PatternTrainingControl : UserControl
    {
        public PatternTrainingControl()
        {
            InitializeComponent();
        }

        private void PatternTrainingControl_Load(object sender, EventArgs e)
        {
            string path0 = Environment.CurrentDirectory;


            string path1 = $"{path0}\\www";
            if (!Directory.Exists(path1))
            {
                Directory.CreateDirectory(path1);
            }


            string path2 = $"{path0}\\www\\pattern";
            if (!Directory.Exists(path2))
            {
                Directory.CreateDirectory(path2);
            }
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            int totalletter = int.Parse(TbSetTotal.Text);

            int startletter = int.Parse(TbPNstart.Text);
            int lenletter = int.Parse(TbPNqty.Text);

            string txt = TbScan.Text;
            int lentxt = txt.Length;
            if (lentxt == totalletter && (startletter + lenletter) <= totalletter)
            {
                string result = txt.Substring(startletter, lenletter);
                TbPartnumber.Text = result;
            }

            int startletter2 = int.Parse(TbPDstart.Text);
            int lenletter2 = int.Parse(TbPDqty.Text);
            if (lentxt == totalletter && (startletter2 + lenletter2) <= totalletter)
            {
                string result = txt.Substring(startletter2, lenletter2);
                TbProductID.Text = result;
            }
        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbSetTotal.Text.Trim() == String.Empty || TbPNstart.Text.Trim() == String.Empty ||
                   TbPNqty.Text.Trim() == String.Empty || TbPDstart.Text.Trim() == String.Empty ||
                   TbPDqty.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Please fill all setting point before saving data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult r = MessageBox.Show("Are you sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No) return;

                string path0 = Environment.CurrentDirectory;

                string path1 = $"{path0}\\www";
                if (!Directory.Exists(path1))
                {
                    Directory.CreateDirectory(path1);
                }

                string path2 = $"{path0}\\www\\pattern";
                if (!Directory.Exists(path2))
                {
                    Directory.CreateDirectory(path2);
                }

                string path = string.Format($"{path2}\\pattern.txt");


                string data = string.Format("{0},{1},{2},{3},{4},{5}", TbSetTotal.Text, TbPNstart.Text, TbPNqty.Text,

                  TbPDstart.Text, TbPDqty.Text, TbScan.Text);

                File.WriteAllText(path, data);
                Param.Patterns.TotalLength = int.Parse(TbSetTotal.Text);

                Param.Patterns.Start = int.Parse(TbPNstart.Text);
                Param.Patterns.Length = int.Parse(TbPNqty.Text);

                Param.Patterns.Start2 = int.Parse(TbPDstart.Text);
                Param.Patterns.Length2 = int.Parse(TbPDqty.Text);
                MessageBox.Show("Save pattern completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

                MessageBox.Show("Save pattern is NOT completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
