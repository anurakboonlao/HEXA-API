using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class AddOnModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ColorCode { get; set; }
        public string LogoPath { get; set; }
        public int GroupAddOnId { get; set; }
        public bool RequiredInput { get; set; }
        public AddOnInputTypeEnum? InputType { get; set; }
    }

    public enum AddOnInputTypeEnum
    {
        TeethNumber = 1,
        Quadrant = 2,
        QuadrantWithAll = 3
    }
}
