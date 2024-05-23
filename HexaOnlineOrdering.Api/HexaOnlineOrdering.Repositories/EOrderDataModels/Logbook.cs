using System;
using System.Collections.Generic;

#nullable disable

namespace HexaOnlineOrdering.Repositories.EOrderDataModels
{
    public partial class Logbook
    {
        public uint Logbookid { get; set; }
        public uint LogOrdId { get; set; }
        public DateTime LogDate { get; set; }
        public string LogType { get; set; }
        public uint LogStfId { get; set; }
        public uint LogSecId { get; set; }
        public int LogStatus { get; set; }
    }
}
