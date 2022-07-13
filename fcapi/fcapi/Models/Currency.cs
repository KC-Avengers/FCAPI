using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class Currency
    {
        public string CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string ShortName { get; set; }
        public string EngName { get; set; }
        public double FixedRate { get; set; }
        public double BuyInRate { get; set; }
        public double SellOutRate { get; set; }
        public short AmountDeciDigits { get; set; }
        public bool AmountThouPt { get; set; }
        public short PriceDeciDigits { get; set; }
        public bool PriceThouPt { get; set; }
        public int? UpdateDate { get; set; }
    }
}
