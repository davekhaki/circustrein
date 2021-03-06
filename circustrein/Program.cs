﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace circustrein
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Animal> circustrein = new List<Animal>();
        
            static T RandomEnumValue<T>()
            {
                var v = Enum.GetValues(typeof(T));
                return (T)v.GetValue(new Random().Next(v.Length));
            }
            for (int i = 0; i < 10; i++)
            {
                var size = RandomEnumValue<Animal.AnimalSize>();
                if(size == Animal.AnimalSize.none)
                {
                    size = Animal.AnimalSize.medium;
                }
                bool meat;
                var decider = random.Next(0, 2);
                if(decider == 1)
                {
                    meat = true;
                } else
                {
                    meat = false;
                }
                circustrein.Add(new Animal(size, meat));
            }

            Console.WriteLine("Unsorted Animals:");
            foreach(Animal unsorted in circustrein)
            {
                Console.WriteLine(unsorted);
            }
            Console.WriteLine("");

            List<Animal> sortedAnimals = WagonMethods.SortAnimals(circustrein);
            Console.WriteLine("Sorted Animals:");
            foreach(Animal bruh in sortedAnimals)
            {
                Console.WriteLine(bruh);
            }

            Console.WriteLine("");
            List<Wagon> finWagons = WagonMethods.FillTrain(sortedAnimals);
            foreach (Wagon bruhwagon in finWagons)
            {
                Console.WriteLine($"Space used in wagon: {10 - bruhwagon.Space}");
                foreach( Animal animalInWagon in bruhwagon.Animals)
                {
                    Console.WriteLine(animalInWagon);
                }             
            }
            Console.ReadKey();
        }
    }
}