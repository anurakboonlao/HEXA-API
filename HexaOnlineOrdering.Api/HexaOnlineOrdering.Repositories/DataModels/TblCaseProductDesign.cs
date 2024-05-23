using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblCaseProductDesign")]
    public class TblCaseProductDesign
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Design")]
        public int DesignId { get; set; }
        [ForeignKey("CaseProduct")]
        public int CaseProductId { get; set; }
        public TblDesign Design { get; set; }
        public TblCaseProduct CaseProduct { get; set; }
    }
}
