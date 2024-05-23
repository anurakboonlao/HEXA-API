using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class CaseItemModel
    {
        public int CaseId { get; set; }

        public string ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public MethodModel Method { get; set; }
        public string Option { get; set; }
        public string No { get; set; }

        public MasterProductModel SelectProduct { get; set; }

        public MaterialModel SelectMaterial { get; set; }

        public DesignModel SelectDesign { get; set; }

        public List<SelectedAddOnModel> SelectAddOn { get; set; }
        public string SelectShade { get; set; }
        public string SelectShadeSystem { get; set; }
        public ShadeSystemModel SelectedShadeSystem { get; set; }
        public ShadeModel SelectedShade { get; set; }
        public string SubstitutionTooth { get; set; }
    }
}
