using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class CustomerAddress
    {
        public short Flag { get; set; }
        public string Id { get; set; }
        public string AddrId { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string LinkMan { get; set; }
    }
}
