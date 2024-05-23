using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblProductMaterial")]
    public class TblProductMaterial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Material")]
        public int MaterialId { get; set; }
        [ForeignKey("Product")]
        public int MasterProductId { get; set; }
        public TblMaterial Material { get; set; }
        public TblMasterProduct Product { get; set; }
    }
}
