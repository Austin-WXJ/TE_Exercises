using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        [TestMethod]
        public void AnimalGroupName()
        {
            AnimalGroupName myAnimalGroupName = new AnimalGroupName();

            Assert.AreEqual("Tower", myAnimalGroupName.GetHerd("giraffe"));
            Assert.AreEqual("Herd", myAnimalGroupName.GetHerd("elephant"));
            Assert.AreEqual("Pride", myAnimalGroupName.GetHerd("lion"));
            Assert.AreEqual("Murder", myAnimalGroupName.GetHerd("crow"));
            Assert.AreEqual("Kit", myAnimalGroupName.GetHerd("pigeon"));
            Assert.AreEqual("Pat", myAnimalGroupName.GetHerd("flamingo"));
            Assert.AreEqual("Herd", myAnimalGroupName.GetHerd("deer"));
            Assert.AreEqual("Pack", myAnimalGroupName.GetHerd("dog"));
            Assert.AreEqual("Float", myAnimalGroupName.GetHerd("crocodile"));
            Assert.AreEqual("Crash", myAnimalGroupName.GetHerd("rhino"));
        }
    }
}
