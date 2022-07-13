using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class Storage
    {
        public string WareId { get; set; }
        public string StorageId { get; set; }
        public string StorageName { get; set; }
        public int Status { get; set; }
    }
}
