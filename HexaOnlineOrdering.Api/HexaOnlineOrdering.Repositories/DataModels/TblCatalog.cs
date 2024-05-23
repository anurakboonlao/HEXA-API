using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblCatalog")]
    public class TblCatalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public string LogoPath { get; set; }
        [ForeignKey("CatalogGroup")]
        public int CatalogGroupId { get; set; }
        public bool Disabled { get; set; }
        public int OrderNumber { get; set; }
        public TblCatalogGroup CatalogGroup { get; set; }
    }

}
