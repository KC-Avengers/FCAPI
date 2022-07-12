using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class OrdRequisitionsSub
    {
        public string BillNo { get; set; }
        public short RowNo { get; set; }
        public string ProdId { get; set; }
        public string ProdName { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public int RequireDate { get; set; }
        public string ItemRemark { get; set; }
        public string InsertDateTime { get; set; }
    }
}
