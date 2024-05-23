using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class DisplayAttachFile
    {
        public int Id { get; set; }
        public int CaseId { get; set; }

        public string FilePath { get; set; }
        public int FileTypeId { get; set; }
        public string FileName { get; set; }
        public DateTime UploadDate { get; set; }
        public long Size { get; set; }

        public int? CasePresentationHistoryId { get; set; }
    }
}
