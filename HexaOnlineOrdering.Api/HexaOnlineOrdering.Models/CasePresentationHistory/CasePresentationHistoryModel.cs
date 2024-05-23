using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models.CasePresentationHistory
{
    public class CasePresentationHistoryModel
    {
        public int Id { get; set; }
        public string Note { get; set; }

        public DateTime RequestEditDate { get; set; }
        public int CaseId { get; set; }

        public List<DisplayAttachFile> RequestCaseAttachedFiles { get; set; }
    }
}
