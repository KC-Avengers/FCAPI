using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class ScheduleEvent
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool FullDay { get; set; }
        public string Title { get; set; }
    }
}
