using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product> {
            new Product {ProductId = 1, Name = "LL Road Frame - Red, 44",  Color = "Red", StandardCost = 187.1571,  ListPrice = 337.22,    CategoryId = 5, ModelId = 3},
            new Product {ProductId = 2, Name = "LL Road Frame - Red, 48",  Color = "Red", StandardCost = 187.1571,  ListPrice = 337.22,    CategoryId = 3, ModelId = 3},
            new Product {ProductId = 3, Name = "LL Road Frame - Red, 52",  Color = "Red", StandardCost = 187.1571,  ListPrice = 337.22,    CategoryId = 1, ModelId = 3},
            new Product {ProductId = 4, Name = "LL Road Frame - Red, 58",  Color = "Red", StandardCost = 187.1571,  ListPrice = 337.22,    CategoryId = 4, ModelId = 4},
            new Product {ProductId = 5, Name = "LL Road Frame - Red, 60",  Color = "Red", StandardCost = 187.1571,  ListPrice = 337.22,    CategoryId = 2, ModelId = 4}
            };
            List<ProductCategory> categories = new List<ProductCategory> {
             new ProductCategory {CategoryId = 1, Name = "Bikes"},
             new ProductCategory {CategoryId = 2, Name = "Components" },
             new ProductCategory {CategoryId = 3, Name = "Clothing"},
             new ProductCategory {CategoryId = 4, Name = "Accessories"},
             new ProductCategory {CategoryId = 5, Name = "Mountain Bikes"},
            };
            List<ProductModel> models = new List<ProductModel> {
            new ProductModel {ModelId = 1, Name = "Classic Vest"},
            new ProductModel {ModelId = 2, Name = "Cycling Cap"},
            new ProductModel {ModelId = 3, Name = "Full-Finger Gloves"},
            new ProductModel {ModelId = 4, Name = "Half-Finger Gloves"},
            new ProductModel {ModelId = 5, Name = "HL Mountain Frame"}
            };
            //1 Group Products By Model
            products
                .GroupBy(p => p.ModelId)
                .Select(gr => new
                {
                    gr.Key,
                    Products = gr
                })
                .ToList()
                .ForEach(g =>
                {
                    var model=models.First(m => m.ModelId == g.Key).Name;
                    Console.WriteLine($"Model ID: {g.Key } Name: { model}" );
                    foreach (var p in g.Products)
                    {
                        Console.WriteLine($"\t{p.Name}, {p.ListPrice}, {p.Color}");
                    }
                    
                });
            Console.ReadLine();
        }
    }
}
