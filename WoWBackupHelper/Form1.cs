using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                FillGridWithBackups();

        }

        private void FillGridWithBackups()
        {

            Regex reg = new Regex(@"WoW_UI-Addon_Backup_.*");

            var files = Directory.GetFiles(@"C:\temp\backuptest\", "*.zip")
                                 .Where(path => reg.IsMatch(path))
                                 .ToList();
            int row = 0;
            foreach (var item in files)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[row].Cells[0].Value = item;
                row++;
            }

        }

        private void btnStartBackup_Click(object sender, EventArgs e)
        {
            if (ValidateConfig())
            {
                CreateBackupNow();
            }

        }

        private bool ValidateConfig()
        {
            if (!cbBackupInterface.Checked && !cbBackupWTF.Checked)
            {
                MessageBox.Show("Select at least one folder to backup. (In \"Settings\"-Tab)", "Error");
                return false;
            }

            return true;
        }

        public void CreateBackupNow()
        {
            string wowPath = @"C:\Program Files (x86)\World of Warcraft\";
            string wtfFolder = wowPath + "WTF";
            string interfaceFolder = wowPath + "Interface";

            var backupFileName = String.Format("WoW_UI-Addon_Backup_{0}.zip", DateTime.Now.ToString("yyyyMMdd_HHmmss"));

            using (ZipFile zip = new ZipFile())
            {

                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Default;

                if (cbBackupWTF.Checked)
                    zip.AddDirectory(wtfFolder, "WTF");

                if (cbBackupInterface.Checked)
                    zip.AddDirectory(interfaceFolder, "Interface");

                zip.SaveProgress += this.SetProgress;
                zip.Save(@"C:\temp\backuptest\" + backupFileName);
            }

        }

        private void SetProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Saving_AfterWriteEntry)
            {
                this.progressBar1.Value = e.EntriesSaved * 100 / e.EntriesTotal;
            }
            else if (e.EventType == ZipProgressEventType.Saving_Completed)
            {
                progressBar1.CreateGraphics().DrawString("Done", new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
