using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace circustrein
{
    public class Train
    {
        public static List<Wagon> wagons = new List<Wagon>();
        public static Wagon CreateNewWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimal(animal);
            wagons.Add(wagon);
            return wagon;
        }

        public override string ToString()
        {
            return $"Train: {wagons}";
        }
    }
}
