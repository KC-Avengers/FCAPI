using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class FinalApprovalPersonalSetting
    {
        public int Sid { get; set; }
        public int OfficialDocumentId { get; set; }
        public int SequenceIndex { get; set; }
        public string FinalApprovalOption { get; set; }
        public string FinalApprovalMember { get; set; }
    }
}
