using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataPotterTests
    {
        KataPotter testPotter = new KataPotter();

        [TestInitialize]
        public void Initialize()
        {
            testPotter = new KataPotter();
        }

        [TestMethod]
        public void Potter_Test()
        {
            Assert.AreEqual(  8.00 , testPotter.GetCost(new int[] { 0, 0, 1, 0, 0 }));
            Assert.AreEqual( 15.20 , testPotter.GetCost(new int[] { 0, 0, 1, 0, 1 }));
            Assert.AreEqual( 23.20 , testPotter.GetCost(new int[] { 0, 0, 2, 0, 1 }));
            Assert.AreEqual( 30.00 , testPotter.GetCost(new int[] { 1, 1, 1, 1, 1 }));
            Assert.AreEqual( 51.20 , testPotter.GetCost(new int[] { 2, 2, 2, 1, 1 }));
            Assert.AreEqual( 51.20 , testPotter.GetCost(new int[] { 1, 2, 1, 2, 2 }));


        }
    }
}
