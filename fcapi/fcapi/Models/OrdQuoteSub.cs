using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class OrdQuoteSub
    {
        public string BillNo { get; set; }
        public short RowNo { get; set; }
        public string ProdId { get; set; }
        public string ProdName { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public decimal Amount { get; set; }
        public decimal? Tax { get; set; }
        public decimal? AmountTax { get; set; }
        public string ItemRemark { get; set; }
    }
}
