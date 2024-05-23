using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class GroupAddOnModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool DisplayAsGroup { get; set; }
        public int OrderNumber { get; set; }
        public List<AddOnModel> AddOns { get; set; }
    }
}
