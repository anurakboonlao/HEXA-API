using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class RejectNoteModel
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime RejectDate { get; set; }
        public int OrderId { get; set; }
        public int RejectUserId { get; set; }
        public UserModel RejectUser { get; set; }
    }
}
