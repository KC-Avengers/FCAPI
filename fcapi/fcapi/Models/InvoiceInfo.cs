using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class InvoiceInfo
    {
        public short SrcBillFlag { get; set; }
        public string SrcBillNo { get; set; }
        public string InvoiceNo { get; set; }
        public int InvoiceDate { get; set; }
        public string CustomerId { get; set; }
        public int ApplyMonth { get; set; }
        public short InvoiceType { get; set; }
        public short TaxType { get; set; }
        public decimal Amount { get; set; }
        public decimal TaxAmt { get; set; }
        public string CompanyName { get; set; }
        public string TaxRegNo { get; set; }
        public string InvoAddr { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public decimal Total { get; set; }
        public string Remark { get; set; }
    }
}
