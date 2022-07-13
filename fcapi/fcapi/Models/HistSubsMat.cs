using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class HistSubsMat
    {
        public long SrcSubSeqNo { get; set; }
        public long RowNo { get; set; }
        public string ReplProdId { get; set; }
        public int InvalidDate { get; set; }
        public string SubsRemark { get; set; }
    }
}
