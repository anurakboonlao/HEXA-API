﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblCaseAttachedFileType")]
    public class TblCaseAttachedFileType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public ICollection<TblCaseAttachedFile> CaseAttachedFiles { get; set; }
    }
}
