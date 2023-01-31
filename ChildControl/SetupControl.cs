using AutoRenderingWorkingStandard.Models;
using AutoRenderingWorkingStandard.Modules.Initial;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AutoRenderingWorkingStandard.ChildControl
{
    public partial class SetupControl : UserControl
    {
        public SetupControl()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string p = Directory.GetCurrentDirectory();

                string path = $"{p}\\static\\SourceFiles";

                FileInfo fi = new FileInfo(TbDestination.Text);

                var filename = TbDestination.Text.Split('\\');
                var len = filename.Length;

                var name = filename[len - 1];

                //var uuid = Guid.NewGuid().ToString();

                string destination = $"{path}\\{name}";

                fi.CopyTo(destination, true);


                using (var db = new WSContext())
                {
                    var record = new WorkingStandard()
                    {
                        Partnumber = ScanText.Text.Substring(0, 10),
                        ScannerText = ScanText.Text,
                        Destination = destination,
                    };
                    db.WorkingStandards.Add(record);
                    db.SaveChanges();
                    MessageBox.Show("Save Image completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ScanText.Text = TbDestination.Text = String.Empty;

                }


            }
            catch
            {
                MessageBox.Show("Save Image is not completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = System.IO.Directory.GetCurrentDirectory();

            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.Title = "Browse Image File";

            openFileDialog1.DefaultExt = "jpg";

            openFileDialog1.ReadOnlyChecked = true;

            openFileDialog1.ShowReadOnly = true;


            openFileDialog1.Filter = "Image files (*.jpg;*.png)|*.jpg;*png|All files (*.*)|*.*";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TbDestination.Text = openFileDialog1.FileName;
            }
        }

        private void SetupControl_Load(object sender, EventArgs e)
        {

            string path1 = $"{Environment.CurrentDirectory}\\Static";

            if (!Directory.Exists(path1))
            {
                Directory.CreateDirectory(path1);
            }

            string path2 = $"{path1}\\Sourcefiles";

            if (!Directory.Exists(path2))
            {
                Directory.CreateDirectory(path2);
            }

            string[] header = new string[] { "key", "No", "Part number", "Source file" };
            int[] width = new int[] { 5, 30, 120, 500 };

            DataGridViewInit.Pattern_1(DgvList, header, width);
        }

        private void BtnListWs_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new WSContext())
                {

                    var wsLists = db.WorkingStandards.ToList();

                    DgvList.Rows.Clear();
                    int i = 0;
                    foreach (var item in wsLists)
                    {
                        DgvList.Rows.Add(item.Id, i++, item.Partnumber, item.Destination);
                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvList.RowCount > 0)
                {
                    DialogResult r = MessageBox.Show("Are you sure ?", "Delete Working-Standard List", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        int row = DgvList.CurrentRow.Index;

                        int key =Convert.ToInt32(DgvList.Rows[row].Cells[0].Value.ToString());
                        DgvList.Rows.RemoveAt(row);

                        using (var db = new WSContext())
                        {
                            var exist = db.WorkingStandards.Where(x=>x.Id == key).ToList();
                            db.WorkingStandards.RemoveRange(exist); 
                            db.SaveChanges();
                            MessageBox.Show("Delete image completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Delete image is NOT completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnCopyTo_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderDlg = new FolderBrowserDialog
                {
                    RootFolder = Environment.SpecialFolder.Desktop,
                    SelectedPath = @"C:\",
                    ShowNewFolderButton = true
                };

                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string path = folderDlg.SelectedPath;

                    int row = DgvList.CurrentRow.Index;

                    string source = DgvList.Rows[row].Cells[3].Value.ToString();

                    string[] files = source.Split('\\');
                    int len = files.Length;
                    string filename = files[len - 1];


                    string destination = $"{path}\\{filename}";
                    FileInfo fi = new FileInfo(destination);
                    fi.CopyTo(destination, true);
                    MessageBox.Show("Copy image to destination completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Copy image to destination Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
