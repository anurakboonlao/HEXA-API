using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblUser")]
    public class TblUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [StringLength(200)]
        public string Username { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Password { get; set; }
        [ForeignKey("UserRole")]
        [Required]
        public int UserRoleId { get; set; }
        public TblUserRole UserRole { get; set; }
        public ICollection<TblNotification> Notifications { get; set; }
        public ICollection<TblFavorite> Favorites { get; set; }
        public int? ContactId { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime LastUpdate { get; set; } = DateTime.Now;
        public bool Active { get; set; } = true;

        // Ignore fields
        [NotMapped]
        public string Role { get { return UserRole?.Name; } }

    }
}
