using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace circustrein
{
    public class Wagon
    {
        public List<Animal> Animals = new List<Animal>();

        public int Space { get; private set; } = 10;

        private Animal.AnimalSize GetMeatEater()
        {
            List<Animal> MeatEaterList = Animals.Where(Animal => Animal.MeatEater).ToList();
            if(MeatEaterList.Count == 0)
            {
                return Animal.AnimalSize.none;

            }
            else
            {
                return MeatEaterList.First().Size;
            }
        }
        public bool AddAnimal(Animal newAnimal)
        {
            if(newAnimal.Size > GetMeatEater() && (int) newAnimal.Size <= Space)
            {
                Animals.Add(newAnimal);
                Space = Space - (int)newAnimal.Size;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public override string ToString()
        {
            return $"{10 - Space}";           
        }
    }
}
