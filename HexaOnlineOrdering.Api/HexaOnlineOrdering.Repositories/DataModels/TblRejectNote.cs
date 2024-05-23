using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblRejectNote")]
    public class TblRejectNote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Note { get; set; }
        public bool IsAdmin { get; set; }

        public DateTime RejectDate { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public TblOrder Order { get; set; }

        [ForeignKey("RejectUser")]
        public int RejectUserId { get; set; }
        public TblUser RejectUser { get; set; }
    }
}
