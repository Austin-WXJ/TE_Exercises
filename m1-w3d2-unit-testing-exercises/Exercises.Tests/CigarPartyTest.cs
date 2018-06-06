using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]
        public void CigarParty()
        {
            CigarParty testCigarParty = new CigarParty();

            Assert.AreEqual(false, testCigarParty.HaveParty(30, false), "Input: CigarParty (30, false)");
            Assert.AreEqual(true, testCigarParty.HaveParty(50, false), "Input: CigarParty (50, false)");
            Assert.AreEqual(true, testCigarParty.HaveParty(70, true), "Input: CigarParty (70, true)");
        }
    }
}
