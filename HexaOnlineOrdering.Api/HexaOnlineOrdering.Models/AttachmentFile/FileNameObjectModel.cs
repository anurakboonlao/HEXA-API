using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models.AttachmentFile
{
    public class FileNameObjectModel
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public FileNameObjectModel(string filePath, string fileName)
        {
            FileName = fileName;
            FilePath = filePath;
        }
    }
}
