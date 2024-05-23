using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblProductDesign")]
    public class TblProductDesign
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Design")]
        public int DesignId { get; set; }
        [ForeignKey("Product")]
        public int MasterProductId { get; set; }
        public TblDesign Design { get; set; }
        public TblMasterProduct Product { get; set; }
    }
}
