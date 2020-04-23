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

            animals.Add(new Animal(Animal.sizes.klein, true));
            animals.Add(new Animal(Animal.sizes.middel, false));
            animals.Add(new Animal(Animal.sizes.middel, false));
            animals.Add(new Animal(Animal.sizes.groot, true));
            animals.Add(new Animal(Animal.sizes.klein, false));

           
            string result = string.Join(",", FillWagonMethod.FillWagon(animals));
            Assert.AreEqual("5,7,1", result);
        }
    }
}
