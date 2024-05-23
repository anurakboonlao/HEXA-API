using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class MasterProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ColorCode { get; set; }
        public string LogoPath { get; set; }
        public int ExpectedProductDay { get; set; }
        public int ProductTypeId { get; set; }
        public ProductTypeModel ProductType { get; set; }

        public List<MaterialModel> Materials { get; set; }
        public List<DesignModel> Designs { get; set; }
        public List<GroupAddOnModel> AddOnGroups { get; set; }

        public string Code { get; set; }
    }
}
