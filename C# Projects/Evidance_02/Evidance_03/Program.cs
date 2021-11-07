using Evidance_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Input");
            Car c = new Car();
            Console.Write($"Model: ");
            c.Model = Console.ReadLine();
            Console.Write($"Make: ");
            c.Make = int.Parse(Console.ReadLine());
            Console.Write($"CC: ");
            c.CC = int.Parse(Console.ReadLine());
            Console.Write($"GearType: ");
            c.GearType = Console.ReadLine();
            Console.Write($"Type 1-NormalCar, 2-FamilyCar, 3-Racing, 4-MountainBike, 5-RoadBike: ");
            c.Type= (VehicleType)int.Parse(Console.ReadLine());
            Console.Write($"Wheels: ");
            c.Wheels = int.Parse(Console.ReadLine());

            //Console.WriteLine($"StartType: ");
            //string input1 = Console.ReadLine();
            //c.AddFeature(input1.Split(','));
            Console.WriteLine();


            Bike b = new Bike();
            Console.Write($"Model: ");
            b.Model = Console.ReadLine();
            Console.Write($"Make: ");
            b.Make = int.Parse(Console.ReadLine());
            Console.Write($"CC: ");
            b.CC = int.Parse(Console.ReadLine());
            Console.Write($"GearType: ");
            b.GearType = Console.ReadLine();
            Console.Write($"Type: 1-NormalCar, 2-FamilyCar, 3-Racing, 4-MountainBike, 5-RoadBike: ");
            b.Type = (VehicleType)int.Parse(Console.ReadLine());
            Console.Write($"StartType: ");
            string input2 = Console.ReadLine();
            b.AddFeature(input2.Split(','));



            Console.WriteLine();
            Console.WriteLine("===OutPut===Car");
            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine("===OutPut===Bike");
            Console.WriteLine(b);


            Console.ReadLine();

        }
    }
}
