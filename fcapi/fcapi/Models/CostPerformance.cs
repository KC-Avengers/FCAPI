using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class CostPerformance
    {
        public int IndexNo { get; set; }
        public string Toppercent { get; set; }
        public string Middle1percent { get; set; }
        public string Middle2percent { get; set; }
        public string Bottompercent { get; set; }
        public string Creator { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
