using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblProductType")]
    public class TblProductType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        public ICollection<TblMethod> Methods { get; set; }
        public ICollection<TblFavorite> Favorites { get; set; }
        public ICollection<TblProductTypeGroup> ProductTypeGroups { get; set; }
        public ICollection<TblMasterProduct> Products { get; set; }
        public ICollection<TblShadeSystem> ShadeSystems { get; set; }
        public ICollection<TblUserRole> UserRole { get; set; }
    }
}
