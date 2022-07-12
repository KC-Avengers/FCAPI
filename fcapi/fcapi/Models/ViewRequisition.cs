using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class ViewRequisition
    {
        public string BillNo { get; set; }
        public int BillDate { get; set; }
        public string DepartId { get; set; }
        public string Maker { get; set; }
        public string Employee { get; set; }
        public string Class { get; set; }
        public string ProdId { get; set; }
        public string ProdName { get; set; }
        public string Unit { get; set; }
        public decimal? Quantity { get; set; }
        public int? RequireDate { get; set; }
    }
}
