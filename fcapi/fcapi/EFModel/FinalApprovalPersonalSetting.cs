using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace fcapi
{
    public partial class FinalApprovalPersonalSetting
    {
        [Key]
        public int Sid { get; set; }
        public int OfficialDocumentId { get; set; }
        public int SequenceIndex { get; set; }
        public string FinalApprovalOption { get; set; }
        public string FinalApprovalMember { get; set; }
    }
}
