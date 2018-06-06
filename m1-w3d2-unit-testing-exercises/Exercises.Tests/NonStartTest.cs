using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        [TestMethod]
        public void NonStart()
        {
            NonStart testNonStart = new NonStart();

            Assert.AreEqual("ellohere", testNonStart.GetPartialString("Hello", "There"));
            Assert.AreEqual("avaode", testNonStart.GetPartialString("java", "code"));
            Assert.AreEqual("hotlava", testNonStart.GetPartialString("shotl", "java"));
            Assert.AreEqual("by", testNonStart.GetPartialString("ab", "xy"));
            Assert.AreEqual("b", testNonStart.GetPartialString("ab", "x"));
            Assert.AreEqual("c", testNonStart.GetPartialString("x", "ac"));
            Assert.AreEqual("", testNonStart.GetPartialString("a", "x"));
            Assert.AreEqual("itat", testNonStart.GetPartialString("kit", "kat"));
            Assert.AreEqual("artart", testNonStart.GetPartialString("mart", "dart"));
        }
    }
}
