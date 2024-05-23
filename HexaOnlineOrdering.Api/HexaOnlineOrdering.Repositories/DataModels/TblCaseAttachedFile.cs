using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HexaOnlineOrdering.Repositories.DataModels
{
    [Table("TblCaseAttachedFile")]
    public class TblCaseAttachedFile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Case")]
        public int CaseId { get; set; }
        public TblCase Case { get; set; }
        public string FilePath { get; set; }

        public string FileName { get; set; }
        public DateTime UploadedDate { get; set; }
        [ForeignKey("CaseAttachedFileType")]
        public int FileTypeId { get; set; }
        public TblCaseAttachedFileType CaseAttachedFileType { get; set; }

        [ForeignKey("CasePresentationHistory")]
        public int? CasePresentationHistoryId { get; set; }
        public TblCasePresentationHistory? CasePresentationHistory { get; set; }
    }
}
