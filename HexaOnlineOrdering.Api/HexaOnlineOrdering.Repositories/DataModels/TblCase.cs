using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using HexaOnlineOrdering.Models;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblCase")]
    public class TblCase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(300)]
        public string CaseName { get; set; }
        [StringLength(300)]
        public string PatientName { get; set; }
        public int UserId { get; set; }
        public TblUser User { get;set;}
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdate { get; set; }
        [ForeignKey("CaseStatus")]
        public int CaseStatusId { get; set; }
        public TblCaseStatus CaseStatus { get; set; }
        public int? OrganizationId { get; set; }
        public int? DoctorId { get; set; }
        [ForeignKey("CaseType")]
        public int CaseTypeId { get; set; }
        public TblCaseType CaseType { get; set; }
        public int? ReferenceOrderId { get; set; }
        public string ReferenceOrderNumber { get; set; }
        public string Memo { get; set; }
        public bool Disabled { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? PickupDate { get; set; }
        public ICollection<TblCaseAttachedFile> CaseAttachedFiles { get; set; }
        public ICollection<TblCaseProduct> CaseProducts { get; set; }
        public TblOrder OrderData { get; set; }
        public int Age { get; set; }
        public GenderEnum? Gender { get; set; }

        public string Aligners { get; set; }
    }

}
