using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace circustrein
{
    public static class WagonMethods
    {
        public static List<Animal> SortAnimals(List<Animal> unsortedAnimals)
        {
            return unsortedAnimals.OrderByDescending(animal => animal.MeatEater).ThenByDescending(animal => (int)animal.Size).ToList();
        }

        public static List<Wagon> FillTrain(List<Animal> allAnimals)
        {
            allAnimals = SortAnimals(allAnimals);

            foreach (Animal animalNow in allAnimals)
            {
                if (animalNow.MeatEater)
                {
                    Train.CreateNewWagon(animalNow);
                }
                else
                {
                    bool notAvailable = false;
                    foreach (Wagon currentWagon in Train.wagons)
                    {
                        notAvailable = currentWagon.AddAnimal(animalNow);
                        if (notAvailable)
                        {
                            break;
                        }
                    }
                    if (!notAvailable)
                    {
                        Train.CreateNewWagon(animalNow);
                    }
                }
            }
            return Train.wagons;
        }
    }
}
