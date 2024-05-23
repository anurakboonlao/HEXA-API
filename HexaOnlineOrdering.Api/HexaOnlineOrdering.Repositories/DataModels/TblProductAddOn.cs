using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblProductAddOn")]
    public class TblProductAddOn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("AddOn")]
        public int AddOnId { get; set; }
        [ForeignKey("Product")]
        public int MasterProductId { get; set; }
        public TblAddOn AddOn { get; set; }
        public TblMasterProduct Product { get; set; }

        [ForeignKey("GroupAddOn")]
        public int? GroupAddOnId { get; set; }
        public TblGroupAddOn GroupAddOn { get; set; }

        public bool RequiredInput { get; set; }
        public AddOnInputTypeEnum? InputType { get; set; }
    }
}

public enum AddOnInputTypeEnum
{
    TeethNumber = 1,
    Quadrant = 2,
    QuadrantWithAll = 3,
    Number = 4,
    Plate =5,
    Sticker = 6,
    Labial = 7,
    Buccal = 8,
    Glitter = 9,
}
