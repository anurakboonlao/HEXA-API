using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using HexaOnlineOrdering.Models;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblFavorite")]
    public class TblFavorite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public TblUser User { get; set; }
        public int ProductTypeId { get; set; }
        public TblProductType ProductType { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public TblMasterProduct Product { get; set; }

        public ICollection<TblFavoriteMaterial> Materials { get; set; }
        public ICollection<TblFavoriteDesign> Designs { get; set; }
        public ICollection<TblFavoriteAddOn> AddOns { get; set; }
        public string Shade { get; set; }
        public string ShadeSystem { get; set; }
        public int? ShadeSystemId { get; set; }
        public int? ShadeId { get; set; }
        [StringLength(200)]
        public string SubstitutionTooth { get; set; }

        [NotMapped]
        public FavoriteMaterialModel[] MaterialModels 
        { 
            get
            {
                return Materials.Select(i => new FavoriteMaterialModel() {
                    MaterialId = i.MaterialId,
                    MaterialName = i.Material.Name
                }).ToArray();
            }
        }

        [NotMapped]
        public FavoriteDesignModel[] DesignModels
        {
            get
            {
                return Designs.Select(i => new FavoriteDesignModel() { 
                    DesignId = i.DesignId,
                    DesignName = i.Design.Name
                }).ToArray();
            }
        }

        [NotMapped]
        public FavoriteAddOnModel[] AddOnModels
        {
            get
            {
                return AddOns.Select(i => new FavoriteAddOnModel() {
                    AddOnId = i.AddOnId,
                    AddOnName = i.AddOn.Name,
                    InputAddOn = i.InputAddOn
                }).ToArray();
            }
        }

        [NotMapped]
        public string ProductName
        {
            get
            {
                return Product.Name;
            }
        }
    }
}
