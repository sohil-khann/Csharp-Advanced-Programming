using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAndLinq.ProductManagement
{
    public class ProductGrouping
    {
        public static void Run()
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Category = "Electronics", Price = 1200.00 },
                new Product { Name = "Smartphone", Category = "Electronics", Price = 800.00 },
                new Product { Name = "Headphones", Category = "Electronics", Price = 150.00 },
                new Product { Name = "Coffee Maker", Category = "Appliances", Price = 100.00 },
                new Product { Name = "Blender", Category = "Appliances", Price = 50.00 },
                new Product { Name = "Desk Chair", Category = "Furniture", Price = 200.00 },
                new Product { Name = "Bookshelf", Category = "Furniture", Price = 150.00 }
            };

            // Group products by category and calculate average price for each category
            var categoryAverages = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    AveragePrice = g.Average(p => p.Price)
                });

            Console.WriteLine(" Average Price by Category ");
            foreach (var item in categoryAverages)
            {
                Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice:C}");
            }
        }
    }
}
