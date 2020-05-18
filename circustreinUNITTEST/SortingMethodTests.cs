using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using circustrein;

namespace circustreinUNITTEST
{
    [TestClass]
    public class SortingMethodTests
    {
        [TestMethod]
        public void SortingMethodTest()
        {
            List<Animal> unsortedList = new List<Animal>();

            unsortedList.Add(new Animal(Animal.AnimalSize.small, true));
            unsortedList.Add(new Animal(Animal.AnimalSize.medium, false));
            unsortedList.Add(new Animal(Animal.AnimalSize.medium, false));
            unsortedList.Add(new Animal(Animal.AnimalSize.large, true));
            unsortedList.Add(new Animal(Animal.AnimalSize.small, false));

            List<Animal> sortedList = WagonMethods.SortAnimals(unsortedList);
            string sortedAnimals = string.Join(",", sortedList);
            Assert.AreEqual("Size: groot, Eats meat: True,Size: klein, Eats meat: True,Size: middel, Eats meat: False,Size: middel, Eats meat: False,Size: klein, Eats meat: False", sortedAnimals);
        }
    }
}
