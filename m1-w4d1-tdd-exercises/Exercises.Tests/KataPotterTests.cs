using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Exercises.Tests
{
    [TestClass]
    public class KataPotterTests
    {
        KataPotter testPotter;

        [TestInitialize]
        public void Initialize()
        {
        }

        [TestMethod]
        public void Potter_TestSort()
        {

            testPotter = new KataPotter(new int[] { 4, 4, 1, 5, 2 });
            CollectionAssert.AreEqual(new int[] { 1, 0, 1, 3, 0 }, testPotter.Collection);



        }
        [TestMethod]
        public void Potter_TestPrice()
        {
            testPotter = new KataPotter(new int[] { 2, 2, 2, 1, 1 });

            //testPotter = new KataPotter(new int[] { 2, 4, 1, 5, 3 });
            // Assert.AreEqual(3946.34, testPotter.GetCost);
            // Assert.AreEqual(  8.00 , testPotter.GetCost(new int[] { 0, 0, 1, 0, 0 }));
            // Assert.AreEqual( 15.20 , testPotter.GetCost(new int[] { 0, 0, 1, 0, 1 }));
            // Assert.AreEqual( 23.20 , testPotter.GetCost(new int[] { 0, 0, 2, 0, 1 }));
            // Assert.AreEqual( 30.00 , testPotter.GetCost(new int[] { 1, 1, 1, 1, 1 }));

            Assert.AreEqual( 51.20M , testPotter.GetCost());
            // Assert.AreEqual( 51.20 , testPotter.GetCost(new int[] { 1, 2, 1, 2, 2 }));

        }

    }
}
