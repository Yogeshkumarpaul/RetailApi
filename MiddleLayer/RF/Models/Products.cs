using System;
using System.Collections.Generic;

namespace RF.Models
{
    public partial class Products
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public int? ProductTypeId { get; set; }
        public decimal? Prate { get; set; }
        public decimal? MarginPer { get; set; }
        public decimal? MarginAmount { get; set; }
        public decimal? Srate { get; set; }
        public decimal? InitStock { get; set; }
        public int? MagUnitId { get; set; }
        public int? ColorId { get; set; }
        public int? ManufacturerId { get; set; }
        public int? SupplierId { get; set; }
        public int? SizeId { get; set; }
        public string SuitableFor { get; set; }
    }
}
