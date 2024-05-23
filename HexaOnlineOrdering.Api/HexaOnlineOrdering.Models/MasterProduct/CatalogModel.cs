using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models.MasterProduct
{
    public class CatalogModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogoPath { get; set; }
        public int OrderNumber { get; set; }
        public int CatalogGroupId { get; set; }
        public string CatalogGroupName { get; set; }
    }
}
