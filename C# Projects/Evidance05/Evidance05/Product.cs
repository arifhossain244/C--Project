using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance05
{
    public class Product
    {
        //new Product {ProductID = 1, Name = "LL Road Frame - Red, 44", ProductNumber = "FR-R38R-44", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 44, Weight = 1052.33, ProductCategoryID = 18, ProductModelID = 9},
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }
        public int CategoryId { get; set; }
        public int ModelId { get; set; }

    }
}
