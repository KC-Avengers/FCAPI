using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class InvoiceMain
    {
        public string InvoiceNo { get; set; }
        public int? InvoiceDate { get; set; }
        public string BillTo { get; set; }
        public string Address { get; set; }
        public string Attn { get; set; }
        public string Maker { get; set; }
        public string Permitter { get; set; }
        public string Remark { get; set; }
        public string InsertDateTime { get; set; }
        public string UpdateDateTime { get; set; }
    }
}
