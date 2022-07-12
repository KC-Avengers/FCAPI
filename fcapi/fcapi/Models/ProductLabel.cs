using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class ProductLabel
    {
        public string ProdId { get; set; }
        public string ProdName { get; set; }
        public string Spec { get; set; }
        public string Element { get; set; }
        public string Storage { get; set; }
        public string Allergen { get; set; }
        public string Warning { get; set; }
        public string Purpose { get; set; }
        public string License { get; set; }
        public string Standard { get; set; }
        public string Llimit { get; set; }
        public string Origin { get; set; }
        public string Manufacturers { get; set; }
        public string Importer { get; set; }
        public string LoginCode { get; set; }
    }
}
