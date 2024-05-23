using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models.CasePresentationHistory
{
    public class AddCasePresentationHistoryModel
    {
        public string Note { get; set; }
        public int OrderId { get; set; }
        public int CaseId { get; set; }
    }
}
