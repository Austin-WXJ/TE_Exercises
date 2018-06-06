using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void Lucky13()
        {
            Lucky13 testLucky13 = new Lucky13();

            Assert.AreEqual(true,  testLucky13.GetLucky(new int[] { 0, 2, 4 }), "Test 1: Input was [0, 2, 4]");
            Assert.AreEqual(false, testLucky13.GetLucky(new int[] { 1, 2, 3 }), "Test 2: Input was [1, 2, 3]");
            Assert.AreEqual(false, testLucky13.GetLucky(new int[] { 1, 2, 4 }), "Test 3: Input was [1, 2, 4]");
            Assert.AreEqual(false, testLucky13.GetLucky(new int[] { 5, 2, 3 }), "Test 4: Input was [5, 2, 3]");
        }
    }
}
