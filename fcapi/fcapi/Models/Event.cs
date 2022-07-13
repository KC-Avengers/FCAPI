using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class Event
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string EventName { get; set; }
        public DateTime? ReviewStartDate { get; set; }
        public DateTime? ReviewEndDate { get; set; }
        public bool? IsDelete { get; set; }
        public string EmployeeId { get; set; }
    }
}
