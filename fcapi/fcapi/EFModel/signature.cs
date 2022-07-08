using System;

namespace fcapi.EFModel
{
    public class signature
    {
        public int id { get; set; }
        public int EmployeeID { get; set; }
        public string Image { get; set; }
        public string ImageTrueName { get; set; }
        public DateTime? Createtime { get; set; }
        public DateTime? Updatetime { get; set; }
        public bool IsDelete { get; set; }
    }
}
