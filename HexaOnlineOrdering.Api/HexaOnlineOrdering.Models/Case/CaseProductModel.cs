using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class CaseProductModel
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public int ProductTypeId { get; set; }
        public int? TeethNumber { get; set; }
        public CaseSectionEnum? Section { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public CaseQuadrantEnum? Quadrant { get; set; }
        public MasterProductModel? Product { get; set; }
    }

    public enum CaseSectionEnum
    {
        None = 0,
        Upper = 1,
        Lower = 2
    }

    public enum CaseQuadrantEnum
    {
        None = 0,
        Q1 = 1,
        Q2 = 2,
        Q3 = 3,
        Q4 = 4,
        All = 5
    }
}
