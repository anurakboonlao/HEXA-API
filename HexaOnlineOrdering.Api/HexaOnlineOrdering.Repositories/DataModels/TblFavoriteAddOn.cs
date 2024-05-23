using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblFavoriteAddOn")]
    public class TblFavoriteAddOn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("AddOn")]
        public int AddOnId { get; set; }
        [ForeignKey("Favorite")]
        public int FavoriteId { get; set; }
        [StringLength(50)]
        public string InputAddOn { get; set; }
        public TblAddOn AddOn { get; set; }
        public TblFavorite Favorite { get; set; }
    }
}
