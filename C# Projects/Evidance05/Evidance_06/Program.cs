using Evidance_06.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Animal a1 = new Animal("Hors", 3, AnimalType.Harvivore, Gender.Male);
            GenericBehavior<Animal> gb = new GenericBehavior<Animal>();
            Console.WriteLine(value: gb.GetGenericBehavior<Animal>(a1));
            SpacificBehavior<Animal> sb = new SpacificBehavior<Animal>();
            Console.WriteLine(sb.GetGenericBehavior<Animal>(a1));
            Console.ReadLine();
        }
    }
}
