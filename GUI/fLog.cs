using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace GUI
{
    public partial class fLog : DevExpress.XtraEditors.XtraForm
    {
        FileInfo[] files;

        public fLog()
        {
            InitializeComponent();
            LoadFiles();
        }

        void LoadFiles()
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(path);
            files = directory.GetFiles("*.log");

            foreach (FileInfo item in files)
                lsbListFiles.Items.Add(item.Name);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            meContent.ResetText();
        }

        private void lsbListFiles_Click(object sender, EventArgs e)
        {
            string fileName = lsbListFiles.GetItemText(lsbListFiles.SelectedIndex);
            foreach (FileInfo item in files)
            {
                if (fileName.Equals(item.Name))
                {
                    meContent.Text = item.OpenText().ReadToEnd();
                    break;
                }
            }
        }
    }
}