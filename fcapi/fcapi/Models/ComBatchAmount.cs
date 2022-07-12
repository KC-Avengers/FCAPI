using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class ComBatchAmount
    {
        public string ProdId { get; set; }
        public string BatchId { get; set; }
        public string WareId { get; set; }
        public string StorageId { get; set; }
        public int ProduceDate { get; set; }
        public int ValidDate { get; set; }
        public decimal Quantity { get; set; }
    }
}
