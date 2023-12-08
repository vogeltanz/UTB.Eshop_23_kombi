using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Eshop.Domain.Entities
{
    [Table(nameof(Product))]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        [StringLength(255)]
        public string? ImageSource { get; set; }
    }
}
