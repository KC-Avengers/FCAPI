using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class HistBommain
    {
        public long Seq { get; set; }
        public short Flag { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string InsertDate { get; set; }
        public string InsertUser { get; set; }
        public string UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public short? UpdateReason { get; set; }
    }
}
