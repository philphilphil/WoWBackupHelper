using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
using WoWBackupHelper.Properties;

namespace WoWBackupHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSettingsTab();
            FillGridWithBackups();

        }

        private void LoadSettingsTab()
        {
            throw new NotImplementedException();
        }

        private void FillGridWithBackups()
        {
            dataGridView1.Rows.Clear();

            List<BackupDataItem> backupFiles = GetBackupFiles(Settings.Default.SavePath);

            int row = 0;
            foreach (var item in backupFiles)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[row].Cells[1].Value = item.Type;
                dataGridView1.Rows[row].Cells[0].Value = item.Date;
                row++;
            }
        }

        private List<BackupDataItem> GetBackupFiles(string pathToBackups)
        {
            string regexPattern = @"WoW_UI-(Full|Addons|Settings)-Backup_(.*).zip";
            List<BackupDataItem> backupItemList = new List<BackupDataItem>();
            Regex reg = new Regex(regexPattern);

            var files = Directory.GetFiles(pathToBackups, "*.zip")
                                 .Where(path => reg.IsMatch(path))
                                 .ToList();

            foreach (var item in files)
            {
                FileInfo f = new FileInfo(item);
                Match matches = reg.Match(item);

                if (matches.Success)
                {
                    var date = DateTime.ParseExact(matches.Groups[2].Value, "yyyyMMdd_HHmmss", CultureInfo.InvariantCulture, DateTimeStyles.None);
                    backupItemList.Add(new BackupDataItem { Type = matches.Groups[1].Value, Date = date });
                }
            }
            return backupItemList;
        }

        private void btnStartBackup_Click(object sender, EventArgs e)
        {
            if (ValidateConfig())
            {
                CreateBackup();
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

        public void CreateBackup()
        {
            string wowPath = @"C:\Program Files (x86)\World of Warcraft\";
            string wtfFolder = wowPath + "WTF";
            string interfaceFolder = wowPath + "Interface";
            string backypType = "";

            using (ZipFile zip = new ZipFile())
            {

                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Default;

                if (cbBackupWTF.Checked && cbBackupInterface.Checked)
                {
                    backypType = "Full";
                    zip.AddDirectory(wtfFolder, "WTF");
                    zip.AddDirectory(interfaceFolder, "Interface");
                }
                else if (cbBackupWTF.Checked)
                {
                    backypType = "Settings";
                    zip.AddDirectory(wtfFolder, "WTF");
                }
                else if (cbBackupInterface.Checked)
                {
                    backypType = "Addons";
                    zip.AddDirectory(interfaceFolder, "Interface");
                }

                var backupFileName = String.Format("WoW_UI-{0}-Backup_{1}.zip", backypType, DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                zip.SaveProgress += this.SetProgress;
                zip.Save(@"C:\temp\backuptest\" + backupFileName);
            }
            FillGridWithBackups();

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
    }
}
