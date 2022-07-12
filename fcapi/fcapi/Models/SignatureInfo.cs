using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class SignatureInfo
    {
        public int Sid { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string SignaturePath { get; set; }
    }
}
