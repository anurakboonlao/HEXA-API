using System;
using System.Collections.Generic;

namespace HexaOnlineOrdering.Models
{
    public class DisplayCaseModel
    {
        public int CaseId { get; set; }
        public string CaseName { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public GenderEnum? Gender { get; set; }
        public string DentistName { get; set; }
        public string ClinicName { get; set; }
        public int DentistId { get; set; }
        public int ClinicId { get; set; }
        public string ProductType { get; set; }
        public string Status { get; set; }
        public string Memo { get; set; }
        public string CaseType { get; set; }
        public int CaseTypeId { get; set; }
        public int UserId { get; set; }
        public string Aligners { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? EstimatedDate { get; set; }
        public int OrderId { get; set; }
        public string OrderRefNumber { get; set; }
        public int? ReferenceOrderId { get; set; }
        public string ReferenceOrderNumber { get; set; }
        public List<CaseItemModel> CaseOrderLists { get; set; }
        public List<CaseAttachedFileModel> AttachedFileList { get;set;}

    }
    public enum GenderEnum
    {
        Male = 0,
        Female = 1
    }
}
