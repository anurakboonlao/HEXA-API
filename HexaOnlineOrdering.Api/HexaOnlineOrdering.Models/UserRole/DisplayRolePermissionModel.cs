using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class DisplayRolePermissionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserCount { get; set; }
        public List<PermissiveProductType> ProductTypeList { get; set; }

    }
    public class PermissiveProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


}
