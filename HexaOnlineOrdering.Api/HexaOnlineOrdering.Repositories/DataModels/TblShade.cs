using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblShade")]
    public class TblShade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
        public int Order { get; set; }

        [ForeignKey("ShadeSystem")]
        public int ShadeSystemId { get; set; }
        public TblShadeSystem ShadeSystem { get; set; }

    }
}
