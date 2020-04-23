using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace circustrein
{
    public class Wagon
    {
        public List<Animal> Animals = new List<Animal>();

        public int space { get; private set; } = 10;

        public Animal.sizes BigMeatEater()
        {
            List<Animal> MeatEaterList = Animals.Where(Animal => Animal.meatEater).ToList();
            if(MeatEaterList.Count == 0)
            {
                return Animal.sizes.geen;

            }
            else
            {
                return MeatEaterList.First().Size;
            }
        }
        public bool AddAnimal(Animal newAnimal)
        {
            if(newAnimal.Size > BigMeatEater() && (int) newAnimal.Size <= space)
            {
                Animals.Add(newAnimal);
                space = space - (int)newAnimal.Size;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public override string ToString()
        {
            return $"{10 - space}";           
        }
    }
}
