using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        //name
        [Display(Name = "Name Product")]
        [Required]
        public string NameProduct { get; set; }
        //price
        [Column(TypeName ="decimal(18,1)")]
        public decimal Price { get; set; }
        //category
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Category { get; set; }
        //description
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Description { get; set; }
        //rating
        [Range(1,5)]
        public float? Rating { get; set; }
    }
}
