using System;

namespace fcapi.EFModel
{
    public class FormEvent
    {
        public int id { get; set; }
        public int Formid { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int Selfpoint { get; set; }
        public int partmentpoint { get; set; }
        public int managerpoint { get; set; }
        public DateTime? Createtime { get; set; }
        public DateTime? Updatetime { get;set; }
        public bool IsDelete { get; set; }
    }
}
