using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class CaseAttachedFileModel
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public string FilePath { get; set; }
        public int FileTypeId { get; set; }
    }
}
