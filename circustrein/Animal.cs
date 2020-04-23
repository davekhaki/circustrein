using System;
using System.Collections.Generic;
using System.Text;

namespace circustrein
{
    public class Animal
    {
        public enum sizes
        {
            groot = 5,
            middel = 3,
            klein = 1,
            geen = 0
        }

        public bool meatEater { get; set; }

        public sizes Size;

        public Animal(sizes size, bool MeatEater)
        {
            Size = size;
            meatEater = MeatEater;
        }
        public override string ToString()
        {
            return $"Size: {Size}, Eats meat: {meatEater}";
        }
    }
}
