using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class ProductTypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MethodModel> Methods { get; set; }
        public List<ProductGroupModel> ProductGroupModels { get; set; }
        public List<ShadeSystemModel> ShadeSystemsModels { get; set; }
    }
}
