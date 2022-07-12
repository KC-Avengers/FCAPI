using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class CustomerLink
    {
        public short Flag { get; set; }
        public string Id { get; set; }
        public string LinkId { get; set; }
        public string LinkMan { get; set; }
        public string LinkManProf { get; set; }
        public string Telephone { get; set; }
        public string FaxNo { get; set; }
        public string Memo { get; set; }
    }
}
