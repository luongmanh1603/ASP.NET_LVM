using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Name Product")]
        public string NameProduct { get; set; }
        [Column(TypeName ="decimal(18,1)")]
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
