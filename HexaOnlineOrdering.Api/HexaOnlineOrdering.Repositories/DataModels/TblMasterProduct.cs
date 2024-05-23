using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblMasterProduct")]
    public class TblMasterProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(9)]
        public string ColorCode { get; set; }
        public string LogoPath { get; set; }
        public int ExpectedProductDay { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        public TblProductType ProductType { get; set; }
        [StringLength(50)]
        public string Code { get; set; }

        public ICollection<TblProductMaterial> Materials { get; set; }
        public ICollection<TblProductDesign> Designs { get; set; }
        public ICollection<TblProductAddOn> AddOns { get; set; }
    }
}
