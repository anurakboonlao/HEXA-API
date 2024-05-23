using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblFavoriteMaterial")]
    public class TblFavoriteMaterial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Material")]
        public int MaterialId { get; set; }
        [ForeignKey("Favorite")]
        public int FavoriteId { get; set; }
        public TblMaterial Material { get; set; }
        public TblFavorite Favorite { get; set; }
    }
}
