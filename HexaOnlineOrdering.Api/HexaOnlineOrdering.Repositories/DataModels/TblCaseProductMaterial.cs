using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblCaseProductMaterial")]
    public class TblCaseProductMaterial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Material")]
        public int MaterialId { get; set; }
        [ForeignKey("CaseProduct")]
        public int CaseProductId { get; set; }
        public TblMaterial Material { get; set; }
        public TblCaseProduct CaseProduct { get; set; }
    }
}
