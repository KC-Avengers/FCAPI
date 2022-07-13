using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class PrdSubsMat
    {
        public short Flag { get; set; }
        public string MainProdId { get; set; }
        public int SrcRowNo { get; set; }
        public string ReplProdId { get; set; }
        public DateTime? InvalidDate { get; set; }
        public string SubsRemark { get; set; }
    }
}
