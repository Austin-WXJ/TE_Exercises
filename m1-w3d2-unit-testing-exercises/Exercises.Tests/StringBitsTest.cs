using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void StringBits()
        {
            StringBits testBits = new StringBits();

            Assert.AreEqual("Hlo",    testBits.GetBits("Hello"));
            Assert.AreEqual("H",      testBits.GetBits("Hi"));
            Assert.AreEqual("Hello",  testBits.GetBits("Heeololeo"));
            Assert.AreEqual("HHH",    testBits.GetBits("HiHiHi"));
            Assert.AreEqual("",       testBits.GetBits(""));
            Assert.AreEqual("Getns",  testBits.GetBits("Greetings"));
            Assert.AreEqual("Coot",   testBits.GetBits("Chocoate"));
            Assert.AreEqual("p",      testBits.GetBits("pi"));
            Assert.AreEqual("HloKte", testBits.GetBits("Hello Kitten"));
            Assert.AreEqual("happy",  testBits.GetBits("hxaxpxpxy"));
        }
    }
}
