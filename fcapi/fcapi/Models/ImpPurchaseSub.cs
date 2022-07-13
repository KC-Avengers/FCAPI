using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class ImpPurchaseSub
    {
        public short Flag { get; set; }
        public string BillNo { get; set; }
        public short RowNo { get; set; }
        public string ProdId { get; set; }
        public string ProdName { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public decimal Amount { get; set; }
        public int PreBuyDay { get; set; }
        public decimal QtyRemain { get; set; }
        public string ItemRemark { get; set; }
    }
}
