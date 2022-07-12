using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class Employee
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string EngName { get; set; }
        public string DeptId { get; set; }
        public string AreaId { get; set; }
        public string LoginMachine { get; set; }
        public bool? ActingIsOpen { get; set; }
    }
}
