using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class OrdQuoteMain
    {
        public string BillNo { get; set; }
        public int BillDate { get; set; }
        public string CustomerId { get; set; }
        public int ValidDate { get; set; }
        public string AddressId { get; set; }
        public string LinkMan { get; set; }
        public string LinkManProf { get; set; }
        public string LinkTelephone { get; set; }
        public string LinkTax { get; set; }
        public string CurrId { get; set; }
        public double ExchRate { get; set; }
        public bool PriceOfTax { get; set; }
        public string SalesMan { get; set; }
        public string DepartId { get; set; }
        public string Maker { get; set; }
        public string Permitter { get; set; }
        public string DueTo { get; set; }
        public short GatherStyle { get; set; }
        public short GatherDelay { get; set; }
        public string GatherOther { get; set; }
        public short CheckStyle { get; set; }
        public short CheckDelay { get; set; }
        public string CheckOther { get; set; }
        public int PrepayDay { get; set; }
        public int EncashDay { get; set; }
        public int AccMonth { get; set; }
        public decimal SumBtaxAmt { get; set; }
        public short TaxType { get; set; }
        public decimal SumTax { get; set; }
        public decimal SumAmtAtax { get; set; }
        public decimal SumQty { get; set; }
        public decimal LocalTotal { get; set; }
        public decimal LocalTax { get; set; }
        public string Remark { get; set; }
        public short BillStatus { get; set; }
        public int EndacaseDate { get; set; }
    }
}
