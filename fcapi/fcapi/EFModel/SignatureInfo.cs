using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace fcapi
{
    public partial class SignatureInfo
    {
        [Key]
        public int Sid { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string SignaturePath { get; set; }
    }
}
