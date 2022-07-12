using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class PackingMat
    {
        public string PackingNo { get; set; }
        public short RowNo { get; set; }
        public string ProdId { get; set; }
        public string ProdName { get; set; }
        public string Nw { get; set; }
        public string Gw { get; set; }
        public string Dimensions { get; set; }
        public string InsertDateTime { get; set; }
    }
}
