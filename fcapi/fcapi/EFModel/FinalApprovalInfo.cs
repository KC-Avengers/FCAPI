using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace fcapi
{
    public partial class FinalApprovalInfo
    {
        [Key]
        public int Sid { get; set; }
        public int UserId { get; set; }
        public int OfficialDocumentId { get; set; }
        public int FinalApprovalCode { get; set; }
        public string FinalApprovalComment { get; set; }
    }
}
