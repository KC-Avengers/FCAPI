using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class PrdTakeMaterial
    {
        public short Flag { get; set; }
        public string TakeMatNo { get; set; }
        public int TakeMatDate { get; set; }
        public short TakeReason { get; set; }
        public short MkOrdType { get; set; }
        public string MkOrdNo { get; set; }
        public string Remark { get; set; }
        public string TakeDept { get; set; }
        public string TakeMan { get; set; }
        public string WorkPdaid { get; set; }
        public string InsertDateTime { get; set; }
        public string UploadDateTime { get; set; }
    }
}
