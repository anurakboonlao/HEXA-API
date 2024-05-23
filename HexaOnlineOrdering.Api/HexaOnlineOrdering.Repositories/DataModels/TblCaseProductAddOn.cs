using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblCaseProductAddOn")]
    public class TblCaseProductAddOn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("AddOn")]
        public int AddOnId { get; set; }
        [ForeignKey("CaseProduct")]
        public int CaseProductId { get; set; }
        [StringLength(50)]
        public string InputAddOn { get; set; }
        public TblAddOn AddOn { get; set; }
        public TblCaseProduct CaseProduct { get; set; }
    }
}
