using System;

namespace fcapi.EFModel
{
    public class ActingSetting
    {
        public int id { get; set; }
        public int EmployeeID { get; set; }
        public bool IsEnable { get; set; }
        public DateTime? Createtime { get; set; }
        public DateTime? Updatetime { get; set; }
        public bool IsDelete { get; set; }
    }
}
