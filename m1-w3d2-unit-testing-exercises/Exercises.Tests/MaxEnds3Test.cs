using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnds3Test
    {
        [TestMethod]
        public void MaxEnd3()
        {
            MaxEnd3 testMaxEnd3 = new MaxEnd3();

            CollectionAssert.AreEqual(new int[] { 3, 3, 3 },    testMaxEnd3.MakeArray(new int[] { 1, 2, 3 }), "Test 1: Input was [1, 2, 3]");
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, testMaxEnd3.MakeArray(new int[] { 11, 5, 9 }), "Test 2: Input was [11, 5, 9]");
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 },    testMaxEnd3.MakeArray(new int[] { 2, 11, 3 }), "Test 3: Input was [2, 11, 3]");
        }
    }
}
