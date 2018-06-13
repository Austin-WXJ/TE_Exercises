using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Exercises.Tests
{
    [TestClass]
    public class KataPotterTests
    {
        KataPotter testPotter;

        [TestMethod]
        public void Potter_TestSort()
        {
            testPotter = new KataPotter(new int[] { 2, 2, 2, 1, 1 });
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 2, 0 }, testPotter.Collection);

            testPotter = new KataPotter(new int[] { 4, 4, 1, 5, 2 });
            CollectionAssert.AreEqual(new int[] { 1, 0, 1, 3, 0 }, testPotter.Collection);


            testPotter = new KataPotter(new int[] { 4, 2, 0, 6, 1 });
            CollectionAssert.AreEqual(new int[] { 2, 2, 1, 1, 0 }, testPotter.Collection);

            testPotter = new KataPotter(new int[] { 5, 5, 5, 0, 0 });
            CollectionAssert.AreEqual(new int[] { 0, 0, 5, 0 ,0 }, testPotter.Collection);


            testPotter = new KataPotter(new int[] { 3, 3, 7, 7, 7 });
            CollectionAssert.AreEqual(new int[] { 0, 0, 1, 6, 0 }, testPotter.Collection);

            testPotter = new KataPotter(new int[] { 4, 4, 4, 3, 3 });
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 2, 2 }, testPotter.Collection);
        }
        [TestMethod]
        public void Potter_TestPrice()
        {
            testPotter = new KataPotter(new int[] { 2, 2, 2, 1, 1 });
            Assert.AreEqual( 51.20M , testPotter.GetCost(), "Price should be $51.20");

            testPotter = new KataPotter(new int[] { 4, 4, 1, 5, 2 });
            Assert.AreEqual(101.6M, testPotter.GetCost(), "Price should be $101.6");

            testPotter = new KataPotter(new int[] { 4, 2, 0, 6, 1 });
            Assert.AreEqual(75.2M, testPotter.GetCost(), "Price should be $75.2");

            testPotter = new KataPotter(new int[] { 5, 5, 5, 0, 0 });
            Assert.AreEqual(84M, testPotter.GetCost(), "Price should be $84.00");

            testPotter = new KataPotter(new int[] { 3, 3, 7, 7, 7 });
            Assert.AreEqual(170.4M, testPotter.GetCost(), "Price should be $170.4");

            testPotter = new KataPotter(new int[] { 4, 4, 4, 3, 3 });
            Assert.AreEqual(119.2M, testPotter.GetCost(), "Price should be $119.20");
        }

    }
}
