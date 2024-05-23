using System;
using HexaOnlineOrdering.Models.Enums;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HexaOnlineOrdering.Models.ERP
{
    public class SaleOrderModel
    {
        [JsonProperty("order_date")]
        public string SendOrderDate { get { return OrderDate.ToString("yyyy-MM-dd"); } }

        [JsonProperty("date_required")]
        public string SendDateRequired { get { return DateRequired.ToString("yyyy-MM-dd"); } }

        [JsonProperty("due_date")]
        public string SendDueDate { get { return DueDate.HasValue? DueDate.Value.ToString("yyyy-MM-dd"):""; } }

        [JsonProperty("doctor_id")]
        public int DoctorId { get; set; }

        [JsonProperty("clinic_id")]
        public int ClinicId { get; set; }

        [JsonProperty("patient")]
        public string Patient { get; set; }

        [JsonProperty("ref")]
        public string Reference { get; set; }

        [JsonProperty("ref_order")]
        public string FromOrderReference { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("files")]
        public List<string> Files { get; set; }

        [JsonProperty("main_products")]
        public List<SaleOrderMainProduct> Products { get; set; }

        [JsonProperty("case_type")]
        public string RealCaseType
        {
            get
            {
                switch (CaseType)
                {
                    case CaseType.NEW:
                        return "NEW";
                    case CaseType.RE_C:
                        return "RE_UM";
                    case CaseType.RE_UM:
                        return "RE_UM";
                    default:
                        return "NEW";
                }
            }
        }

        [JsonIgnore]
        public CaseType CaseType { get; set; }

        [JsonIgnore]
        public DateTime OrderDate { get; set; }

        [JsonIgnore]
        public DateTime DateRequired { get; set; }

        [JsonIgnore]
        public DateTime? DueDate { get; set; }
    }
}
