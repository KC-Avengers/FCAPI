using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class Product
    {
        public string ProdId { get; set; }
        public string ClassId { get; set; }
        public string BarCodeId { get; set; }
        public string Unit { get; set; }
        public string ProdName { get; set; }
        public string InvoProdName { get; set; }
        public string EngName { get; set; }
        public string CurrId { get; set; }
        public string ModeId { get; set; }
        public bool SafeStock { get; set; }
        public string MaterialWare { get; set; }
        public bool PriceOfTax { get; set; }
        public double? SuggestPrice { get; set; }
        public double? SafeStockQty { get; set; }
        public string ConverUnit { get; set; }
        public double? ConverRate { get; set; }
        public decimal? PackAmt1 { get; set; }
        public decimal? PackAmt2 { get; set; }
        public string PackUnit1 { get; set; }
        public string PackUnit2 { get; set; }
        public byte[] ProdPic { get; set; }
        public string Description { get; set; }
    }
}
