using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class PrdBommain
    {
        public short Flag { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal BatchAmount { get; set; }
        public string NorProdtLine { get; set; }
        public string NorProdtFact { get; set; }
        public string Remark { get; set; }
        public string Maker { get; set; }
        public string Permitter { get; set; }
        public string LastUpdateDateTime { get; set; }
        public string LastUpdateUser { get; set; }
    }
}
