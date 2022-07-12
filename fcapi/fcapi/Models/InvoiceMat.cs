using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class InvoiceMat
    {
        public string InvoiceNo { get; set; }
        public short RowNo { get; set; }
        public string ProdId { get; set; }
        public string ProdName { get; set; }
        public string BatchId { get; set; }
        public decimal Quantity { get; set; }
        public int? ProduceDate { get; set; }
        public int? ValidDate { get; set; }
        public string WareId { get; set; }
        public string StorageId { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public decimal Amount { get; set; }
        public string InsertDateTime { get; set; }
    }
}
