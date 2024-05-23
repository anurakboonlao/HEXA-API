using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblOrder")]
    public class TblOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Case")]
        public int CaseId { get; set; }
        public TblCase Case { get; set; }
        [StringLength(50)]
        public string ReferenceNumber { get; set; }
        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }
        public TblOrderStatus OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? EstimatedDate { get; set; }
        public bool Disabled { get; set; }
        public ICollection<TblOrderHistory> OrderHistorys { get; set; }
        public bool IsNotification { get; set; }

        public TblRejectNote RejectNote { get; set; }
    }
}
