using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class ViewStkBill
    {
        public short Flag { get; set; }
        public string BillNo { get; set; }
        public int BillDate { get; set; }
        public string CustomerId { get; set; }
        public string ProdId { get; set; }
        public string BatchId { get; set; }
        public decimal? Quantity { get; set; }
        public int? ProduceDate { get; set; }
        public int? ValidDate { get; set; }
        public string WareId { get; set; }
        public string StorageId { get; set; }
        public int? IsGift { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Tax { get; set; }
        public decimal? AmountTax { get; set; }
    }
}
