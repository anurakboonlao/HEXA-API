 using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblCaseProduct")]
    public class TblCaseProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Case")]
        public int CaseId { get; set; }
        public TblCase Case { get; set; }
        
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        public TblProductType ProductType { get; set; }

        [ForeignKey("Method")]
        public int MethodId { get; set; }
        public TblMethod Method { get; set; }
        public int? TeethNumber { get; set; }
        public CaseSectionEnum? Section { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public TblMasterProduct Product { get; set; }

        public int Qty { get; set; }
        public CaseQuadrantEnum? Quadrant { get; set; }
        [StringLength(300)]
        public string Option { get; set; }
        [StringLength(200)]
        public string Shade { get; set; }
        [StringLength(200)]
        public string ShadeSystem { get; set; }
        [StringLength(200)]
        public string SubstitutionTooth { get; set; }

        public ICollection<TblCaseProductMaterial> Materials { get; set; }
        public ICollection<TblCaseProductDesign> Designs { get; set; }
        public ICollection<TblCaseProductAddOn> AddOns { get; set; }

        [ForeignKey("ShadeSystemObject")]
        public int? ShadeSystemId { get; set; }
        public TblShadeSystem ShadeSystemObject { get; set; }

        [ForeignKey("ShadeObject")]
        public int? ShadeId { get; set; }
        public TblShade ShadeObject { get; set; }
        

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
