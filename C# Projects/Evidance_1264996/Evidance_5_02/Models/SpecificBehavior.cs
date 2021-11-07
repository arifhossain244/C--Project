using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_5_02.Models
{
    class SpecificBehavior<T> : ISpecificBehavior<T>
    {
        public string GetGenericBehavior<T>(T obj) where T : Animal
        {
            switch (obj.Type)
            {
                case AnimalType.Harvivore:
                    return "Docile, Plant earts";
                case AnimalType.Carvivore:
                    return "Canine, Meat earts";
                case AnimalType.Omnivore:
                    return "Adaptable, Eating everything edible";
                default:
                    return "Unkown Animal Type";
            }
        }
    }
}
