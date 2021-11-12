using System;
using System.Collections.Generic;

#nullable disable

namespace Finalprojectwebapi.Models
{
    public partial class Device
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string Brand { get; set; }
        public double? Price { get; set; }
        public string Imagepath { get; set; }
    }
}
