using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblProductTypeGroup")]
    public class TblProductTypeGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public bool DisplayAsGroup { get; set; }
        public int OrderNumber { get; set; }
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        public TblProductType ProductType { get; set; }
        public ICollection<TblProductGroupItem> ProductGroupItems { get; set; }      
    }
}
