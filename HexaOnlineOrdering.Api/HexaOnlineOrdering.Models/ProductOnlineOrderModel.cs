using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class ProductOnlineOrderModel : ProductModel
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string ColorCode { get; set; }
        public string LogoPath { get; set; }
        public int EOrderProductId { get; set; }
        public List<ProductOnlineOrderModel> SubProducts { get; set; }
        public int UnitId { get; set; }
        public int ProductCategoryId { get; set; }
    }
}
