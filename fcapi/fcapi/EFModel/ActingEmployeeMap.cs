using System;

namespace fcapi.EFModel
{
    public class ActingEmployeeMap
    {
        public int id { get; set; }
        public int EmployeeID { get; set; }
        public int ActingEmployeeID { get; set; }
        public DateTime? Createtime { get; set; }
        public DateTime? Updatetime { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? endtime { get; set; }
        public bool IsDelete { get; set; }
    }
}
