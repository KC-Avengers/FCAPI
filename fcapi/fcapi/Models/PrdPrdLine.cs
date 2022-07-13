using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class PrdPrdLine
    {
        public string LineId { get; set; }
        public string LineName { get; set; }
        public string LinkMan { get; set; }
        public string Phone { get; set; }
        public string Remark { get; set; }
        public short MergeOutState { get; set; }
        public string ProdtMan { get; set; }
    }
}
