using HexaOnlineOrdering.Models.Marketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class OrderDetailModel
    {
        public int Id { get; set; }


        public string OrderRef { get; set; }
        public int CaseId { get; set; }
        public string CaseName { get; set; }

        public string PatientName { get; set; }
        public int Age { get; set; }
        public GenderEnum? Gender { get; set; }
        public DateTime OrderedDate { get; set; }
        public DateTime? RequestedDate { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public string Memo { get; set; }

        public List<DisplayAttachFile> PathAttachedFiles { get; set;}
        public int Status { get; set; }
        public bool IsNotification { get; set; }

        public int UserId { get; set; }

        public int DoctorId { get; set; }
        public int ClinicId { get; set; }
        public MarketingMemberModel Doctor { get; set; }
        public MarketingMemberModel Clinic { get; set; }

        public string Aligners { get; set; }
        public RejectNoteModel  RejectNote { get; set; }
    }
}
