using System;
using Microsoft.AspNetCore.Http;

namespace HexaOnlineOrdering.Models
{
    public class AdvertiseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public bool Disabled { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int OrderNumber { get; set; }
        public IFormFile File { get; set; }
        public string Url { get; set; }
    }
}
