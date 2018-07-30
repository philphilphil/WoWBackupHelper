using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

namespace WoWBackupHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartBackup_Click(object sender, EventArgs e)
        {
            CreateBackupNow();
        }



        public void CreateBackupNow()
        {
            string wowPath = @"C:\Program Files (x86)\World of Warcraft\";
            string wtfFolder = wowPath + "WTF";
            string interfaceFolder = wowPath + "Interface";

            using (ZipFile zip = new ZipFile())
            {

                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Default;
                zip.AddDirectory(wtfFolder, "WTF");
                zip.AddDirectory(interfaceFolder, "Interface");
                zip.SaveProgress += this.SetProgress;
                zip.Save(@"C:\temp\test.zip");
            }

        }

        private void SetProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Saving_AfterWriteEntry)
            {
                this.progressBar1.Value = e.EntriesSaved * 100 / e.EntriesTotal;
            }
        }
    }
}
