using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblCaseType")]
    public class TblCaseType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public ICollection<TblCase> Cases { get; set; }
    }
}
