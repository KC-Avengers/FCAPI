using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class ImpPurchaseMain
    {
        public short Flag { get; set; }
        public string BillNo { get; set; }
        public int BillDate { get; set; }
        public string CustomerId { get; set; }
        public string ShipCustomerId { get; set; }
        public string AddressId { get; set; }
        public string CurrId { get; set; }
        public string Packing { get; set; }
        public string Payment { get; set; }
        public string Deliver { get; set; }
        public string Insurance { get; set; }
        public string ExchCondition { get; set; }
        public string Documents { get; set; }
        public string SendFrom { get; set; }
        public string Dest { get; set; }
        public int PrepayDay { get; set; }
        public int EncashDay { get; set; }
        public decimal SumQty { get; set; }
        public decimal TotalOriginal { get; set; }
        public decimal Commision { get; set; }
        public string SalesMan { get; set; }
        public string DepartId { get; set; }
        public string ProjectId { get; set; }
        public string Maker { get; set; }
        public string Permitter { get; set; }
        public string Remark { get; set; }
        public short BillStatus { get; set; }
        public int? EndacaseDate { get; set; }
    }
}
