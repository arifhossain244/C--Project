using Evidance_5_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_5_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal ab = new Animal("Hourse", 3, AnimalType.Harvivore, Gender.Male);
            Animal ad = new Animal("Hourse", 4, AnimalType.Omnivore, Gender.Male);
            GenericBehavior<Animal> gb = new GenericBehavior<Animal>();
            Console.WriteLine(gb.GetGenericBehavior(ab));
            Console.WriteLine(gb.GetGenericBehavior(ad));
            Animal ac = new Animal("Hourse", 3, AnimalType.Carvivore, Gender.Female);
            Animal aj = new Animal("Hourse", 2, AnimalType.Harvivore, Gender.Male);
            SpecificBehavior<Animal> sb = new SpecificBehavior<Animal>();
            Console.WriteLine(sb.GetGenericBehavior(ac));
            Console.WriteLine(sb.GetGenericBehavior(aj));
            Console.ReadLine();
        }
    }
}
