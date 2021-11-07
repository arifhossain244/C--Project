using Evidance_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
            new Product {ProductId = 1, Name = "LL Road Frame - Red, 44", ProductNumber = "FR-R38R-44", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 44, Weight = 1052.33, CategoryId = 18, ModelId = 2},
            new Product {ProductId = 2, Name = "LL Road Frame - Red, 48", ProductNumber = "FR-R38R-48", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 48, Weight = 1070.47, CategoryId = 18, ModelId = 1},
            new Product {ProductId = 3, Name = "LL Road Frame - Red, 52", ProductNumber = "FR-R38R-52", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 52, Weight = 1088.62, CategoryId = 18, ModelId = 5},
            new Product {ProductId = 4, Name = "LL Road Frame - Red, 58", ProductNumber = "FR-R38R-58", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 58, Weight = 1115.83, CategoryId = 18, ModelId = 9},
            new Product {ProductId = 5, Name = "LL Road Frame - Red, 60", ProductNumber = "FR-R38R-60", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 60, Weight = 1124.9,  CategoryId = 18, ModelId = 6},
            new Product {ProductId = 6, Name = "LL Road Frame - Red, 62", ProductNumber = "FR-R38R-62", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 62, Weight = 1133.98, CategoryId = 18, ModelId = 10},
            new Product {ProductId = 7, Name = "ML Road Frame - Red, 44", ProductNumber = "FR-R72R-44", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 44, Weight = 1006.97, CategoryId = 18, ModelId = 8},
            new Product {ProductId = 8, Name = "ML Road Frame - Red, 48", ProductNumber = "FR-R72R-48", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 48, Weight = 1025.11, CategoryId = 18, ModelId = 4},
            new Product {ProductId = 9, Name = "ML Road Frame - Red, 52", ProductNumber = "FR-R72R-52", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 52, Weight = 1043.26, CategoryId = 18, ModelId = 3},
            new Product {ProductId = 10,Name = "ML Road Frame - Red, 58", ProductNumber = "FR-R72R-58", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 58, Weight = 1070.47, CategoryId = 18, ModelId = 7},
            new Product {ProductId = 12,Name = "HL Mountain Frame - Silver, 44", ProductNumber = "FR-M94S-44", Color = "Silver", StandardCost = 706.811, ListPrice = 1364.5, Size = 44, Weight = 1251.91, CategoryId = 16, ModelId = 11}
            };
            List<ProductCategory> categories = new List<ProductCategory>
            {
             new ProductCategory {CategoryId = 1, Name = "Bikes"},
             new ProductCategory {CategoryId = 2, Name = "Components" },
             new ProductCategory {CategoryId = 3, Name = "Clothing"},
             new ProductCategory {CategoryId = 4, Name = "Accessories"},
             new ProductCategory {CategoryId = 5, Name = "Mountain Bikes"},
             new ProductCategory {CategoryId = 6, Name = "Road Bikes" },
             new ProductCategory {CategoryId = 7, Name = "Touring Bikes"},
             new ProductCategory {CategoryId = 8, Name = "Handlebars"},
             new ProductCategory {CategoryId = 9, Name = "Bottom Brackets"},
             new ProductCategory {CategoryId = 10, Name = "Brakes"},
             new ProductCategory {CategoryId = 11, Name = "Chains"},
             new ProductCategory {CategoryId = 12, Name = "Cranksets"}
            };
            List<ProductModel> models = new List<ProductModel>
            {
             new ProductModel {ModelId = 1, Name = "Classic Vest"},
             new ProductModel {ModelId = 2, Name = "Cycling Cap"},
             new ProductModel {ModelId = 3, Name = "Full-Finger Gloves"},
             new ProductModel {ModelId = 4, Name = "Half-Finger Gloves"},
             new ProductModel {ModelId = 5, Name = "HL Mountain Frame"},
             new ProductModel {ModelId = 6, Name = "HL Road Frame" },
             new ProductModel {ModelId = 7, Name = "HL Touring Frame" },
             new ProductModel {ModelId = 8, Name = "LL Mountain Frame"},
             new ProductModel {ModelId = 9, Name = "LL Road Frame"},
             new ProductModel {ModelId = 10, Name = "LL Touring Frame"},
             new ProductModel {ModelId = 11, Name = "Long-Sleeve Logo Jersey"},
             new ProductModel {ModelId = 12, Name = "Men's Bib-Shorts"}
            };
            //2 Gropu products by Category
            categories
               .GroupBy(p => p.CategoryId)
               .Select(gr => new {
                   gr.Key,
                   categories = gr
               })
                 .ToList()
                 .ForEach(g =>
                 {
                     var model = models.First(m => m.ModelId == g.Key).Name;
                     Console.WriteLine($"Model Id{g.Key} Name:{model}");
                     Console.WriteLine(g.Key);
                     foreach (var p in g.categories)
                     {
                         Console.WriteLine($"\t{p.CategoryId}, {p.Name} ");
                     }
                 });
            //3 Inner Join 
            Console.WriteLine();
            var q = from p in products
                    join m in models on p.ModelId equals m.ModelId
                    join c in categories on p.CategoryId equals c.CategoryId
                    select new { Categoty = c.Name, Model = m.Name, p.Name, p.StandardCost, p.ListPrice, p.Color };
            foreach (var x in q)
            {
                Console.WriteLine($"{x.Name} Category: {x.Categoty}, Model: {x.Model} Price: {x.ListPrice}");
            }
            //4 Left Outer Join 
            Console.WriteLine();
            var q1 = from c in categories
                     join p in products on c.CategoryId equals p.CategoryId into cp
                     from np in cp.DefaultIfEmpty()
                     select new { Category = c.Name, np?.Name, np?.ListPrice, np?.Color };
            foreach (var x in q1)
            {
                Console.WriteLine($" Category: {x.Category}, Category Name:{x.Name}  Price: {x.ListPrice}");
            }
            Console.ReadLine();
        }
    }
}
