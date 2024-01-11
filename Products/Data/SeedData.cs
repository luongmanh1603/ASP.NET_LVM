using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Products.Data;
using System;
using System.Linq;

namespace Products.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ProductsContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ProductsContext>>()))
        {
            // Look for any movies.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }
            context.Product.AddRange(
                new Product
                {
                    NameProduct = "Laptop lenion 5",
                    Price =  25000,
                    Category = "Laptop",
                    Description = "San pham gaming"
                }
                
            );
            context.SaveChanges();
        }
    }
}