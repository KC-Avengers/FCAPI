using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class EventItem
    {
        public int Id { get; set; }
        public int? EventId { get; set; }
        public int? Sort { get; set; }
        public int? CeoScore { get; set; }
        public int? SelfScore { get; set; }
        public int? SupervisorScore { get; set; }
        public string Topic { get; set; }
        public string Type { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? Createtime { get; set; }
        public bool? Isattendance { get; set; }
        public int? Absence { get; set; }
        public int? Late { get; set; }
        public int? Sick { get; set; }
        public int? Special { get; set; }
    }
}
