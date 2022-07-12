using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace fcapi
{
    public partial class ScheduleEvent
    {
        [Key]
        public int id { get; set; }
        public int UserId { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public bool fullDay { get; set; }
        public string title { get; set; }
    }
}
