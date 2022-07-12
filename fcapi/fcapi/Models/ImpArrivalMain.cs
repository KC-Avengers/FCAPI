using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class ImpArrivalMain
    {
        public short Flag { get; set; }
        public string BillNo { get; set; }
        public int BillDate { get; set; }
        public string CustomerId { get; set; }
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
        public string Remark { get; set; }
        public string DepartId { get; set; }
        public string ProjectId { get; set; }
        public string Maker { get; set; }
        public string Permitter { get; set; }
        public string WorkPdaid { get; set; }
        public string InsertDateTime { get; set; }
        public string UploadDateTime { get; set; }
    }
}
