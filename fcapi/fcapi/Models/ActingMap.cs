using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class ActingMap
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeactingId { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Endtime { get; set; }
        public DateTime? Createtime { get; set; }
    }
}
