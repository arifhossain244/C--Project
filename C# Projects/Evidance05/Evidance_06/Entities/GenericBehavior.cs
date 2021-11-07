namespace Evidance_06.Entities
{
    public class GenericBehavior
    {
        public string GetGenericBehavior<T>(ref T obj)
        {
            if (obj is Animal)
            {
                Animal a = obj as Animal;
                switch (a.Type)
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
            else
            {
                return "Not Animal";
            }
        }
    }
}