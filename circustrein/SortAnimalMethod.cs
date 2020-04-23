using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace circustrein
{
    public static class SortAnimalMethod
    {
        public static List<Animal> SortAnimals(List<Animal> unsortedAnimals)
        {
            return unsortedAnimals.OrderByDescending(animal => animal.meatEater).ThenByDescending(animal => (int)animal.Size).ToList();
        }
    }
}
