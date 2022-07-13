using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fcapi.ViewModel.Event
{
    public class reviewFormDto
    {
        public DateTime? arrivalDate { get; set; }
        public DateTime? createdDate { get; set; }

        public department department { get; set; }
        public employee employee { get; set; }

        public List<eventItem>? eventItems { get; set; }
        public int eventId { get; set; }
        public string eventName { get; set; }
        public string jobTitle { get; set; }
        
        public reviewDateRange reviewDateRange {get;set;}
    }

    public class department
    {
        public string name { get; set; }
        public string type { get; set; }
    }
    public class employee
    {
        public string name { get; set; }
        public string number { get; set; }
    }
    public class eventItem
    {
        public string? topic { get; set; }
        public int? sort { get; set; }

        public string? type { get; set; }

        public bool? isattendance { get; set; }
        public scores? scores { get; set; }
        public attendance? attendance { get; set; }
    }
    public class reviewDateRange
    {
        public DateTime? starttime { get; set; }
        public DateTime? endtime { get; set; }
    }

    public class scores
    {
        public int? ceoScore { get; set; }
        public int? selfScore { get; set; }
        public int? supervisorScore { get; set; }
    }

    public class attendance
    {
        public int? absence { get; set; }
        public int? late { get; set; }
        public int? sick { get; set; }
        public int? special { get; set; }
    }
}
