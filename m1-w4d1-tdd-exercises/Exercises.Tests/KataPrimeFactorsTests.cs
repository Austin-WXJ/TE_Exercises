using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /* OPTIONAL */
    [TestClass]
    public class KataPrimeFactorsTests
    {
        KataPrimeFactors newFactor;

        [TestInitialize]
        public void Initialize()
        {
            newFactor = new KataPrimeFactors();
        }
        [TestMethod]
        public void PrimeFactor_Test()
        {
            CollectionAssert.AreEqual(new int[] { 2 }, newFactor.Factor(2));
            CollectionAssert.AreEqual(new int[] { 3 }, newFactor.Factor(3));
            CollectionAssert.AreEqual(new int[] { 2, 2 }, newFactor.Factor(4));
            CollectionAssert.AreEqual(new int[] { 2, 3 }, newFactor.Factor(6));
            CollectionAssert.AreEqual(new int[] { 7 }, newFactor.Factor(7));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2 }, newFactor.Factor(8));
            CollectionAssert.AreEqual(new int[] { 3, 3 }, newFactor.Factor(9));
            CollectionAssert.AreEqual(new int[] { 2, 5 }, newFactor.Factor(10));

            
        }

    }
}
