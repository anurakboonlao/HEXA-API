using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models.Case
{
    public class DraftCaseModel
    {
        public int CaseTypeId { get; set;}
        public int UserId { get; set; }
        public int DentistId { get; set; }
        public int ClinicId { get; set; }

        public int? OrderId { get; set; }

        public string OrderRef { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public GenderEnum? Gender { get; set; }
    }

}
