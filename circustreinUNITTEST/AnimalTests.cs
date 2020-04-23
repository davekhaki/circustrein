using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using circustrein;

namespace circustreinUNITTEST
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void ToStringTest()
        {
            Animal animal = new Animal(
                Animal.sizes.groot,
                true
            );

            Assert.AreEqual("Size: groot, Eats meat: True", animal.ToString());
        }
    }
}
