using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class Customer
    {
        public short Flag { get; set; }
        public string Id { get; set; }
        public string ClassId { get; set; }
        public string AreaId { get; set; }
        public string CurrencyId { get; set; }
        public string FullName { get; set; }
        public string FundsAttribution { get; set; }
        public string TaxNo { get; set; }
        public string ShortName { get; set; }
        public string InvoiceTitle { get; set; }
        public string ResponsibleEmployee { get; set; }
        public int? IsFactory { get; set; }
        public string Remark { get; set; }
    }
}
