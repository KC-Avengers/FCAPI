using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fcapi.DTO
{
    public class Result
    {
        public bool issucess { get; set; }
        public string response { get; set; }
        public object Data { get; set; }
    }
}
