using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblFavoriteDesign")]
    public class TblFavoriteDesign
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Design")]
        public int DesignId { get; set; }
        [ForeignKey("Favorite")]
        public int FavoriteId { get; set; }
        public TblDesign Design { get; set; }
        public TblFavorite Favorite { get; set; }
    }
}
