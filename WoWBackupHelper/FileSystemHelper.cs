using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWBackupHelper
{
    class FileSystemHelper
    {
        public DirectoryInfo WoWFolderPath { get; set; }

        public FileSystemHelper()
        {
            
        }

        public void GetWoWFolderPath()
        {
            string path1 = @"C:\Program Files (x86)\World of Warcraft";
            
            if (Directory.Exists(path1))
            {
                this.WoWFolderPath = new DirectoryInfo(path1);
            }
        }
    }
}
