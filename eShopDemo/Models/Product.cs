﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopDemo.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public decimal ActualPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public int UnitsSold { get; set; } = 0;
        public int UnitsQuantity { get; set; }
        public int Rating { get; set; } = 0;
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

    }
}
