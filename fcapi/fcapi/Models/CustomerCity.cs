using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class CustomerCity
    {
        public short Flag { get; set; }
        public string ClassId { get; set; }
        public string CityId { get; set; }
        public string CityName { get; set; }
        public string EngName { get; set; }
    }
}
