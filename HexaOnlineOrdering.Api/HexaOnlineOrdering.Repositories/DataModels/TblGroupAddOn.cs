using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblGroupAddOn")]
    public class TblGroupAddOn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }
        public int OrderNumber { get; set; }

        public ICollection<TblProductAddOn> ProductAddOns { get; set; }
    }
}
