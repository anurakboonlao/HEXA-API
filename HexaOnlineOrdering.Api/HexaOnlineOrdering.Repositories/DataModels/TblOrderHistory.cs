using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblOrderHistory")]
    public class TblOrderHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public TblOrder Order { get; set; }
        public DateTime LastUpdate { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public TblUser User { get; set; }
        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }
        public TblOrderStatus OrderStatus { get; set; }
    }
}
