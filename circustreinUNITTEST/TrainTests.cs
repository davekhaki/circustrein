using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using circustrein;

namespace circustreinUNITTEST
{
    [TestClass]
    public class TrainTests
    {
        [TestMethod]
        public void NewWagonTest()
        {
            //test to check the amount of space is used.
            Animal animal = new Animal(Animal.AnimalSize.small, false);

            string animalsInWagon = string.Join(",", Train.CreateNewWagon(animal));
       
            Assert.AreEqual("1", animalsInWagon);
        }
    }
}