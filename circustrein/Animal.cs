using System;
using System.Collections.Generic;
using System.Text;

namespace circustrein
{
    public class Animal
    {
        public enum AnimalSize
        {
            large = 5,
            medium = 3,
            small = 1,
            none = 0
        }

        public bool MeatEater { get; set; }

        public AnimalSize Size;

        public Animal(AnimalSize size, bool MeatEater)
        {
            Size = size;
            this.MeatEater = MeatEater;
        }
        public override string ToString()
        {
            return $"Size: {Size}, Eats meat: {MeatEater}";
        }
    }
}
