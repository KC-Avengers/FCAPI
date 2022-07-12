using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace fcapi
{
    public partial class AccessPermissionSetting
    {
        [Key]
        public int Sid { get; set; }
        public int OfficialDocumentId { get; set; }
        public int AccessPermissionCode { get; set; }
    }
}
