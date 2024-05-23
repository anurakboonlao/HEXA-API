using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models.Orders
{
    public class AdminReportModel
    {
        public string RowKey { get; set; }

        public int StatusId { get; set; }
        public string Status { get; set; }
        public string OrderRef { get; set; }     
        public string DentistName { get; set; }
        public string ClinicName { get; set; }
        public int DentistId { get; set; }
        public int ClinicId { get; set; }
        public string PatientName { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductType { get; set; }

        public int ProductTypeId { get; set; }
        public string CaseType { get; set; }
        public string Method { get; set; }

        public RejectNoteModel RejectNote { get; set; }

        public List<SelectedProduct> SelectedProducts { get; set; }
    }
}
