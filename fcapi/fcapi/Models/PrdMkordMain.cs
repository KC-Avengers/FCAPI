using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class PrdMkordMain
    {
        public short Flag { get; set; }
        public string MkordNo { get; set; }
        public int MkordDate { get; set; }
        public string ProductId { get; set; }
        public decimal ProdtQty { get; set; }
        public string Producer { get; set; }
        public short ProductType { get; set; }
        public short SourceType { get; set; }
        public string SourceNo { get; set; }
        public string Functionary { get; set; }
        public string Maker { get; set; }
        public string Permitter { get; set; }
        public string Remark { get; set; }
        public int EstTakeMatDate { get; set; }
        public int EstWareInDate { get; set; }
        public int EstStockOutDate { get; set; }
        public short BillStatus { get; set; }
        public int? EndCaseDate { get; set; }
    }
}
