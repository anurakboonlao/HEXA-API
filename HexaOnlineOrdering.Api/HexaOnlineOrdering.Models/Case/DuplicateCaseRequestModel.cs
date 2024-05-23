using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class DuplicateCaseRequestModel
    {
        public int CaseId { get; set; }
        public int UserId { get; set; }
        public int DentistId { get; set; }
        public int ClinicId { get; set; }
    }
}
