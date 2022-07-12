using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class FinalApprovalInfo
    {
        public int Sid { get; set; }
        public int UserId { get; set; }
        public int OfficialDocumentId { get; set; }
        public int FinalApprovalCode { get; set; }
        public string FinalApprovalComment { get; set; }
    }
}
