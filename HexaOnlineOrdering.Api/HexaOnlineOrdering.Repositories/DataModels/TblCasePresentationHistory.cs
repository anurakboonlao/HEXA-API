using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblCasePresentationHistory")]
    public class TblCasePresentationHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Note { get; set; }


        public DateTime RequestEditDate { get; set; }

        [ForeignKey("Case")]
        public int CaseId { get; set; }
        public TblCase Case { get; set; }

        public ICollection<TblCaseAttachedFile> RequestCaseAttachedFiles { get; set; }
    }
}
