using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class CustomerTrade
    {
        public short Flag { get; set; }
        public string Id { get; set; }
        public short? TypeOfPayExpire { get; set; }
        public short? DaysOfPayExpire { get; set; }
        public short? DateOfCheck { get; set; }
        public short? TypeOfBillExpire { get; set; }
        public short? DaysOfBillExpire { get; set; }
        public bool? PriceOfTax { get; set; }
        public short? TypeOfInvoice { get; set; }
        public short? StyleOfInvoice { get; set; }
        public short? TypeOfTax { get; set; }
        public bool? InvoicePriceOfTax { get; set; }
        public string BankAccount { get; set; }
        public string BankNo { get; set; }
    }
}
