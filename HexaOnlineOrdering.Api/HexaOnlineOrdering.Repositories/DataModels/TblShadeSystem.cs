using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblShadeSystem")]
    public class TblShadeSystem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
        public int Order { get; set; }
        public ICollection<TblShade> Shades { get; set; }

        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        public TblProductType ProductType { get; set; }
    }
}
