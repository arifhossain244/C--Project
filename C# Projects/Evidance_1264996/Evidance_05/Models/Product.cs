using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_05.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }
        public int Size { get; set; }
        public Double Weight { get; set; }
        public int CategoryId { get; set; }
        public int ModelId { get; set; }
    }
}
