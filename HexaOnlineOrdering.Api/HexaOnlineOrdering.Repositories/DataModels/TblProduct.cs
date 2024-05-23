using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblProduct")]
    public class TblProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(200)]
        public string DisplayName { get; set; }
        [StringLength(9)]
        public string ColorCode { get; set; }
        public string LogoPath { get; set; }
        public int EOrderProductId { get; set; }

        [ForeignKey("Unit")]
        public int UnitId { get; set; }
        [ForeignKey("ProductCategory")]
        public int ProductCategoryId { get; set; }
        public TblProductCategory ProductCategory { get; set; }
        public TblUnit Unit { get; set; }
    }
}
