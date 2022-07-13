using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class PrdBommat
    {
        public short Flag { get; set; }
        public string ProductId { get; set; }
        public int RowNo { get; set; }
        public string SubProdId { get; set; }
        public decimal QtyOfBatch { get; set; }
        public decimal QtyOfWasting { get; set; }
        public short MatSource { get; set; }
        public string MatsRemark { get; set; }
    }
}
