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

            unsortedList.Add(new Animal(Animal.sizes.klein, true));
            unsortedList.Add(new Animal(Animal.sizes.middel, false));
            unsortedList.Add(new Animal(Animal.sizes.middel, false));
            unsortedList.Add(new Animal(Animal.sizes.groot, true));
            unsortedList.Add(new Animal(Animal.sizes.klein, false));

            List<Animal> sortedList = SortAnimalMethod.SortAnimals(unsortedList);
            string sortedAnimals = string.Join(",", sortedList);
            Assert.AreEqual("Size: groot, Eats meat: True,Size: klein, Eats meat: True,Size: middel, Eats meat: False,Size: middel, Eats meat: False,Size: klein, Eats meat: False", sortedAnimals);
        }
    }
}
