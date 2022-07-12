using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class AccessPermissionSetting
    {
        public int Sid { get; set; }
        public int OfficialDocumentId { get; set; }
        public int AccessPermissionCode { get; set; }
    }
}
