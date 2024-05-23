using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblAds")]
    public class TblAds
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public bool Disabled { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int OrderNumber { get; set; }
        public string URL { get; set; }
    }
}
