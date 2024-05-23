using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblProductGroupItem")]
    public class TblProductGroupItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("ProductTypeGroup")]
        public int ProductTypeGroupId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public TblProductTypeGroup ProductTypeGroup { get; set; }
        public TblMasterProduct Product { get; set; }
    }
}
