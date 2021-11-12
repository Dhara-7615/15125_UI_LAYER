using System;
using System.Collections.Generic;

#nullable disable

namespace Finalprojectwebapi.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int? Price { get; set; }
        public int? Quantity { get; set; }
        public int? Total { get; set; }
        public string Imagepath { get; set; }
    }
}
