using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class CostBonu
    {
        public int IndexNo { get; set; }
        public string Salespercent { get; set; }
        public string Dutypercent { get; set; }
        public string Assistantpercen { get; set; }
        public string Area { get; set; }
        public string Creator { get; set; }
        public DateTime? Createdate { get; set; }
        public string Updater { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
