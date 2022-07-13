using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class OrdRequisitionsMain
    {
        public string BillNo { get; set; }
        public int BillDate { get; set; }
        public string BillClass { get; set; }
        public string DepartId { get; set; }
        public string SalesMan { get; set; }
        public string Maker { get; set; }
        public string Permitter { get; set; }
        public string Remark { get; set; }
        public string InsertDateTime { get; set; }
        public string UpdateDateTime { get; set; }
    }
}
