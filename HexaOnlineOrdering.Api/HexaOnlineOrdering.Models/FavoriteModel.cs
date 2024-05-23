using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class FavoriteModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public FavoriteMaterialModel[] MaterialModels { get; set; }
        public FavoriteDesignModel[] DesignModels { get; set; }
        public FavoriteAddOnModel[] AddOnModels { get; set; }
        public string Shade { get; set; }
        public string ShadeSystem { get; set; }
        public int ShadeId { get; set; }
        public int ShadeSystemId { get; set; }
        public string SubstitutionTooth { get; set; }
    }

    public class FavoriteMaterialModel
    {
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
    }

    public class FavoriteDesignModel
    {
        public int DesignId { get; set; }
        public string DesignName { get; set; }
    }

    public class FavoriteAddOnModel
    {
        public int AddOnId { get; set; }
        public string AddOnName { get; set; }
        public string InputAddOn { get; set; }
    }
}
