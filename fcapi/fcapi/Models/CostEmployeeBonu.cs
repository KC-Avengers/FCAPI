using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class CostEmployeeBonu
    {
        public int IndexNo { get; set; }
        public string EmployeeId { get; set; }
        public string Role { get; set; }
        public string Area { get; set; }
        public string Bonus { get; set; }
        public string Creator { get; set; }
        public DateTime? Createdate { get; set; }
        public string Updater { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
