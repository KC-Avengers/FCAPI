using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class PackingMain
    {
        public string PackingNo { get; set; }
        public int? PackingDate { get; set; }
        public string ShipTo { get; set; }
        public string Address { get; set; }
        public string Attn { get; set; }
        public string Maker { get; set; }
        public string Permitter { get; set; }
        public string Remark { get; set; }
        public string InsertDateTime { get; set; }
        public string UpdateDateTime { get; set; }
    }
}
