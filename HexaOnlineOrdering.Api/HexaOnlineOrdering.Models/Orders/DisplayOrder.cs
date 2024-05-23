using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class DisplayOrder
    {
        public int OrderId { get; set; }

        public string OrderRef { get; set; }
        public int Status { get; set; }

        public string DentistName { get; set; }
        public string ClinicName { get; set; }
        public int DentistId { get; set; }
        public int ClinicId { get; set; }
        public string PatientName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? RequestDeliveryDate { get; set; }
        public DateTime? EstimatetionDate { get; set; }
        public bool Disabled { get; set; }
        public string ProductType { get; set; }
        public List<int> ProductTypeIds { get; set; }
        public string CaseType { get; set; }

        /// add on task HEXA-298 [Online Ordering] Print order PDF layout and print to PDF
        /// for order detail data on PDF
        public DisplayCaseModel DisplayCase { get; set; }
        public int CaseId { get; set; }
        public bool IsNotification { get; set; }
    }
}
