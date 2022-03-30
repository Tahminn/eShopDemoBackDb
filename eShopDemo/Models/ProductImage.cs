using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eShopDemo.Models
{
    public class ProductImage:BaseEntity
    {
        public string Image { get; set; }
        public bool IsMain { get; set; } = false;
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [NotMapped, Required]
        public IFormFile Photo { get; set; }
    }
}
