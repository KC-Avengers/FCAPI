using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class PrdTakeMat
    {
        public short Flag { get; set; }
        public string TakeMatNo { get; set; }
        public int RowNo { get; set; }
        public string SubProdId { get; set; }
        public string BatchId { get; set; }
        public decimal Quantity { get; set; }
        public int? ProduceDate { get; set; }
        public int? ValidDate { get; set; }
        public string WareId { get; set; }
        public string StorageId { get; set; }
        public int IsBad { get; set; }
        public string Remark { get; set; }
        public string InsertDateTime { get; set; }
        public string InsertUserNo { get; set; }
    }
}
