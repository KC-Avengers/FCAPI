using System;

namespace fcapi
{
    public class Form
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool IsDelete { get; set; }
        public int CreateMemberID { get; set; }
    }
}
