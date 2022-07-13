using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class StkBillMain
    {
        public short Flag { get; set; }
        public string BillNo { get; set; }
        public int BillDate { get; set; }
        public string CustBillNo { get; set; }
        public string CustomerId { get; set; }
        public short AssignSend { get; set; }
        public string ShipCustomerId { get; set; }
        public string AddressId { get; set; }
        public string LinkMan { get; set; }
        public string LinkManProf { get; set; }
        public string LinkTelephone { get; set; }
        public string LinkFax { get; set; }
        public string CurrId { get; set; }
        public double ExchRate { get; set; }
        public bool PriceOfTax { get; set; }
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
        public string Remark { get; set; }
        public string DepartId { get; set; }
        public string ProjectId { get; set; }
        public string Maker { get; set; }
        public string Permitter { get; set; }
        public string WorkPdaid { get; set; }
        public string InsertDateTime { get; set; }
        public string UploadDateTime { get; set; }
        public string Voucher { get; set; }
        public string ZipCode { get; set; }
        public string CustAddress { get; set; }
        public string SalesId { get; set; }
        public decimal Total { get; set; }
        public decimal Tax { get; set; }
        public decimal SumAmtAtax { get; set; }
        public decimal SumNum { get; set; }
        public short TaxType { get; set; }
        public short InvoStyle { get; set; }
        public decimal CashPay { get; set; }
        public decimal VisaPay { get; set; }
        public decimal Deposit { get; set; }
        public decimal Payoff { get; set; }
        public string InvoiceNo { get; set; }
    }
}
