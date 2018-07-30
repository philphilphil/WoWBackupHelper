using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWBackupHelper
{
    class BackupService
    {
        public void CreateBackupNow()
        {
            string wowPath = @"C:\Program Files (x86)\World of Warcraft\";
            string wtfFolder = wowPath + "WTF";
            string interfaceFolder = wowPath + "Interface";

            using (ZipFile zip = new ZipFile())
            {
                zip.AddDirectory(wtfFolder, "WTF");
                zip.AddDirectory(interfaceFolder, "Interface");
                zip.Save(@"C:\temp\test.zip");
            }

        }
    }
}
