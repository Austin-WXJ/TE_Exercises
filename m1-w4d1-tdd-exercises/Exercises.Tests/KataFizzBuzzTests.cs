using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Exercises;


namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        KataFizzBuzz testFizzBuzz;

        [TestInitialize]
        public void Initialize()
        {
            testFizzBuzz = new KataFizzBuzz();
        }

        [TestMethod]
        public void Fizz_Test() //test if multiple of 3 Fizz is printed
        {
            Assert.AreNotEqual("3", testFizzBuzz.FizzBuzz(3));
            Assert.AreEqual("Fizz", testFizzBuzz.FizzBuzz(3));
            Assert.AreEqual("Buzz", testFizzBuzz.FizzBuzz(51));
            Assert.AreNotEqual("Fizz", testFizzBuzz.FizzBuzz(15));
            Assert.Fail(testFizzBuzz.FizzBuzz(0));
            Assert.Fail(testFizzBuzz.FizzBuzz(101));


        }
        [TestMethod]
        public void Buzz_Test() //test if multiple of 5 Buzz is printed
        {
            Assert.AreNotEqual("5", testFizzBuzz.FizzBuzz(5));
            Assert.AreEqual("Buzz", testFizzBuzz.FizzBuzz(5));
            Assert.AreEqual("Buzz", testFizzBuzz.FizzBuzz(50));
            Assert.AreNotEqual("Buzz", testFizzBuzz.FizzBuzz(15));

        }
        [TestMethod]
        public void FizzBuzz_Test() //test if multiple of 3 and 5 FizzBuzz is printed
        {
            Assert.AreEqual("FizzBuzz", testFizzBuzz.FizzBuzz(15));
            Assert.AreEqual("FizzBuzz", testFizzBuzz.FizzBuzz(45));
        }
        [TestMethod]
        public void FizzBuzz_Test_Part2()
        {
            Assert.AreEqual("Fizz", testFizzBuzz.FizzBuzz(38));
            Assert.AreEqual("Buzz", testFizzBuzz.FizzBuzz(57));
            Assert.AreEqual("FizzBuzz", testFizzBuzz.FizzBuzz(53));
            Assert.AreEqual("FizzBuzz", testFizzBuzz.FizzBuzz(35));
            
        }
    }
}
