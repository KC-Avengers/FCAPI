using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class HistBommat
    {
        public long SrcSeqNo { get; set; }
        public long SubSeq { get; set; }
        public string SubProdId { get; set; }
        public decimal QtyOfBatch { get; set; }
        public decimal QtyOfWasting { get; set; }
        public short MatSource { get; set; }
        public string MatsRemark { get; set; }
    }
}
