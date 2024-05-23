using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Models
{
    public class NetforceResponseModel<T> where T : class, new()
    {
        public string Id { get; set; }
        public T Result { get; set; }
        public NetforceError Error { get; set; }
    }

    public class NetforceResponseModel
    {
        public string Id { get; set; }
        public string Result { get; set; }
        public NetforceError Error { get; set; }
    }

    public class NetforceError
    {
        public string Message { get; set; }
    }
   
}
