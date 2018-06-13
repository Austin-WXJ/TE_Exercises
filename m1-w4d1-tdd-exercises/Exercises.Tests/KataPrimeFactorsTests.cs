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
        public void PrimeFactor_Test2s()
        {
            CollectionAssert.AreEqual(new int[] { 2 }, newFactor.Factor(2));
            CollectionAssert.AreEqual(new int[] { 2, 2 }, newFactor.Factor(4));
            CollectionAssert.AreEqual(new int[] { 2, 2, 2 }, newFactor.Factor(8));


        }

        [TestMethod]
        public void PrimeFactor_Test3s()
        {
            CollectionAssert.AreEqual(new int[] { 3 }, newFactor.Factor(3));
            CollectionAssert.AreEqual(new int[] { 2, 3 }, newFactor.Factor(6));
            CollectionAssert.AreEqual(new int[] { 3, 3 }, newFactor.Factor(9));
        }

        [TestMethod]
        public void PrimeFactor_Test5s()
        {
            CollectionAssert.AreEqual(new int[] { 2, 5 }, newFactor.Factor(10));
        }

        [TestMethod]
        public void PrimeFactor_TestExtras()
        {
            CollectionAssert.AreEqual(new int[] { 7 }, newFactor.Factor(7));
        }
        [TestMethod]
        public void PrimeFactors_BigNumbers()
        {
            //Borrowed from Alex Jarman

            //result = primeFactors.Factorize(223092870);
            CollectionAssert.AreEquivalent(new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, newFactor.Factor(223092870), "Factorize(223092870) should return {2, 3, 5, 7, 11, 13, 17, 19, 23}");

           // result = primeFactors.Factorize(2147483646);
            CollectionAssert.AreEquivalent(new int[] { 2, 3, 3, 7, 11, 31, 151, 331 }, newFactor.Factor(2147483646), "Factorize(2147483646) should return {2, 3, 3, 7, 11, 31, 151, 331}");

            //result = primeFactors.Factorize(2147483647);
            CollectionAssert.AreEquivalent(new int[] { 2147483647 }, newFactor.Factor(2147483647), "Factorize(2147483647) should return {2147483647}");
        }
    }
}
