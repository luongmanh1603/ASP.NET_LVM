using Microsoft.AspNetCore.Mvc.Rendering;

namespace Products.Models
{
    public class ProductCategoryViewModel
    {
        public List<Product>? Products { get; set; }
        public SelectList? Category { get; set; }
        public string? ProductCategory { get; set; }
        public string? SearchString { get; set; }
    }
}
