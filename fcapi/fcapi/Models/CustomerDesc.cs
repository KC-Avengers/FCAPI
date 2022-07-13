using System;
using System.Collections.Generic;

#nullable disable

namespace fcapi.Models
{
    public partial class CustomerDesc
    {
        public short Flag { get; set; }
        public string Id { get; set; }
        public string EngFullName { get; set; }
        public string EngShortName { get; set; }
        public string TradeCondition { get; set; }
        public string EngLinkMan { get; set; }
        public string EngLinkManProf { get; set; }
        public string EngWayOfRecv { get; set; }
        public string EngWayOfDeliv { get; set; }
        public string AddrId { get; set; }
        public string DeliverAddrId { get; set; }
        public string EngAddrId { get; set; }
    }
}
