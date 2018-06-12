using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
        KataRomanNumerals conversionTest;

        [TestInitialize]
        public void Initialize()
        {
            conversionTest = new KataRomanNumerals();

        }

        [TestMethod]
        public void RomanNumeral_1to10()
        {
            Assert.AreEqual("I", conversionTest.ConvertToRomanNumeral(1));
            Assert.AreEqual("IV", conversionTest.ConvertToRomanNumeral(4));
            Assert.AreEqual("VI", conversionTest.ConvertToRomanNumeral(6));
            Assert.AreEqual("IX", conversionTest.ConvertToRomanNumeral(9));
            Assert.AreEqual("X", conversionTest.ConvertToRomanNumeral(10));
        }
        [TestMethod]
        public void RomanNumeral_Test4s()
        {
            Assert.AreEqual("IV", conversionTest.ConvertToRomanNumeral(4));
            Assert.AreEqual("XLIV", conversionTest.ConvertToRomanNumeral(44));
            Assert.AreEqual("CDXLIV", conversionTest.ConvertToRomanNumeral(444));

        }
        [TestMethod]
        public void RomanNumeral_Test9s()
        {
            Assert.AreEqual("IX", conversionTest.ConvertToRomanNumeral(9));
            Assert.AreEqual("XCIX", conversionTest.ConvertToRomanNumeral(99));
            Assert.AreEqual("CMXCIX", conversionTest.ConvertToRomanNumeral(999));
        }

        [TestMethod]
        public void RomanToArablic()
        {
            Assert.AreEqual(1, conversionTest.ConvertRomanToArabic("I"));
            Assert.AreEqual(9, conversionTest.ConvertRomanToArabic("IX"));
            Assert.AreEqual(99, conversionTest.ConvertRomanToArabic("XCIX"));
            Assert.AreEqual(999, conversionTest.ConvertRomanToArabic("CMXCIX"));
            Assert.AreEqual(444, conversionTest.ConvertRomanToArabic("CDXLIV"));
            Assert.AreEqual(44, conversionTest.ConvertRomanToArabic("XLIV"));
            Assert.AreEqual(4, conversionTest.ConvertRomanToArabic("IV"));
        }
        [TestMethod]
        public void RomanNumerals_TestOddsAndEnds()
        {
            Assert.AreEqual(2708, conversionTest.ConvertRomanToArabic("MMDCCVIII"));

        }
    }
}
