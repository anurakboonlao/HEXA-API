using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class EmailModel
    {
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }
        public string TargetEmail { get; set; }
    }
}
