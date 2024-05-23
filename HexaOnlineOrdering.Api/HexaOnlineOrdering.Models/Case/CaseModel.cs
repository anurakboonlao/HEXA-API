using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class CaseModel
    {
        public int Id { get; set; }
        public string CaseName { get; set; }
        public string PatientName { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public int CaseStatusId { get; set; }
        public int? OrganizationId { get; set; }
        public int? DoctorId { get; set; }
        public int CaseTypeId { get; set; }
        public int? ReferenceCaseId { get; set; }
        public string Memo { get; set; }
        public bool Disabled { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? PickupDate { get; set; }
        public int MethodId { get; set; }
        public int ProductTypeId { get; set; }
        public int Age { get; set; }
        public GenderEnum? Gender { get; set; }
        public string Aligners { get; set; }
    }

   
}
