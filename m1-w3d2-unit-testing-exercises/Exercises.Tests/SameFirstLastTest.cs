using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        [TestMethod]
        public void SameFirstLast()
        {
            SameFirstLast testFirstLast = new SameFirstLast();

            Assert.AreEqual(false,testFirstLast.IsItTheSame(new int[] { 1, 2, 3 }), "Test 1: Input was [1, 2, 3]");
            Assert.AreEqual(true, testFirstLast.IsItTheSame(new int[] { 1, 2, 3, 1 }), "Test 2: Input was [1, 2, 3, 1]");
            Assert.AreEqual(true, testFirstLast.IsItTheSame(new int[] { 1, 2, 1 }), "Test 3: Input was [1, 2, 1]");
        }
    }
}
