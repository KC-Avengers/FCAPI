using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class PrdMkOrdMat
    {
        public short Flag { get; set; }
        public string MkOrdNo { get; set; }
        public int RowNo { get; set; }
        public string SubProdId { get; set; }
        public decimal OughtQty { get; set; }
        public decimal OriginalQty { get; set; }
        public decimal WestingQty { get; set; }
        public short MatSource { get; set; }
    }
}
