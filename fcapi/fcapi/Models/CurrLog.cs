using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class CurrLog
    {
        public string CurrId { get; set; }
        public double? BuyInRate { get; set; }
        public double? SellOutRate { get; set; }
        public string UpdateDate { get; set; }
    }
}
