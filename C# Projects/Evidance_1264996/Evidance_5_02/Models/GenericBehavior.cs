using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_5_02.Models
{
    public class GenericBehavior<T> : IGenericBehavior<T>
    {
        public string GetGenericBehavior<T>(T obj)
        {

            if (obj is Animal)
            {
                Animal a = obj as Animal;
                switch (a.Type)
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
            else
            {
                return "Unknown type";
            }
        }
    }
}
