using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_06.Entities
{
    public class SpacificBehavior<T> : ISpecificBehavior<T>
    {
        public string GetGenericBehavior<T>(ref T obj) where T : Animal
        {
            switch (obj.Type)
            {
                case AnimalType.Harvivore:
                    return "Docile, Plant eaters";
                case AnimalType.Carvivore:
                    return "Canine, Meat eaters";
                case AnimalType.Omnivore:
                    return "Adaptable, Eating everything edible";
                default:
                    return "Unknown animal type";
            }
        }
    }
}
