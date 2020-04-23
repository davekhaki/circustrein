using System;
using System.Collections.Generic;
using System.Text;

namespace circustrein
{
    public static class FillWagonMethod
    {
        public static List<Wagon> FillWagon(List<Animal> everyAnimal)
        {         
                everyAnimal = SortAnimalMethod.SortAnimals(everyAnimal);

                foreach (Animal animalNow in everyAnimal)
                {
                    if (animalNow.meatEater)
                    {
                        Train.NewWagon(animalNow);
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
                            Train.NewWagon(animalNow);
                        }
                    }
                }
            return Train.wagons;          
        }
    }
}