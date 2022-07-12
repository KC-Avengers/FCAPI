using System;

namespace fcapi.DTO
{
    public class DTO_ScheduleEvent
    {
        public int id { get; set; }
        public string title { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public bool fullDay { get; set; }
        
    }
}
