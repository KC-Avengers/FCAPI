using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class StkBillDiscountMain
    {
        public short Flag { get; set; }
        public string BillNo { get; set; }
        public int BillDate { get; set; }
        public string FromNo { get; set; }
        public string Maker { get; set; }
        public string Permitter { get; set; }
        public decimal SumBtaxAmt { get; set; }
        public short TaxType { get; set; }
        public decimal SumTax { get; set; }
        public decimal SumAmtAtax { get; set; }
        public decimal SumQty { get; set; }
        public decimal LocalTotal { get; set; }
        public decimal LocalTax { get; set; }
        public string Remark { get; set; }
        public string InsertDateTime { get; set; }
    }
}
