using System;
using System.Collections.Generic;
using System.Text;
using circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace circustreinUNITTEST
{
    [TestClass]
    public class FillWagonMethodTests
    {
        [TestMethod]
        public void FillWagonMethodTest()
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Animal(Animal.AnimalSize.small, true));
            animals.Add(new Animal(Animal.AnimalSize.medium, false));
            animals.Add(new Animal(Animal.AnimalSize.medium, false));
            animals.Add(new Animal(Animal.AnimalSize.large, true));
            animals.Add(new Animal(Animal.AnimalSize.small, false));

           
            string result = string.Join(",", WagonMethods.FillTrain(animals));
            Assert.AreEqual("5,7,1", result);
        }
    }
}
