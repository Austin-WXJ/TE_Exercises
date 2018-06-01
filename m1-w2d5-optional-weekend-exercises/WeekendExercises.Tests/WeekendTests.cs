using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class WeekendTests
    {
        Exercises exercises = new Exercises();



        /*
         arrayCount9([1, 2, 9]) → 1
         arrayCount9([1, 9, 9]) → 2
         arrayCount9([1, 9, 9, 3, 9]) → 3
         */
        [TestMethod]
        public void arrayCount9()
        {
            Assert.AreEqual(1, exercises.ArrayCount9(new int[] { 1, 2, 9 }), "Input {1, 2, 9}");
            Assert.AreEqual(2, exercises.ArrayCount9(new int[] { 1, 9, 9 }), "Input {1, 9, 9}");
            Assert.AreEqual(3, exercises.ArrayCount9(new int[] { 1, 9, 9, 3, 9 }), "Input {1, 9, 9, 3, 9}");
            Assert.AreEqual(0, exercises.ArrayCount9(new int[] { 1, 2, 3 }), "Input {1, 2, 3}");
            Assert.AreEqual(0, exercises.ArrayCount9(new int[] { }), "Input { }");
            Assert.AreEqual(0, exercises.ArrayCount9(new int[] { 4, 2, 4, 3, 1 }), "Input { 4, 2, 4, 3, 1 }");
            Assert.AreEqual(1, exercises.ArrayCount9(new int[] { 9, 2, 4, 3, 1 }), "Input { 9, 2, 4, 3, 1 }");
        }



        /*
         arrayFront9([1, 2, 9, 3, 4]) → true
         arrayFront9([1, 2, 3, 4, 9]) → false
         arrayFront9([1, 2, 3, 4, 5]) → false
         */
        [TestMethod]
        public void arrayFront9()
        {
            Assert.AreEqual(true, exercises.ArrayFront9(new int[] { 1, 2, 9, 3, 4 }), "Input: {1, 2, 9, 3, 4} ");
            Assert.AreEqual(false, exercises.ArrayFront9(new int[] { 1, 2, 3, 4, 9 }), "Input: {1, 2, 3, 4, 9} ");
            Assert.AreEqual(false, exercises.ArrayFront9(new int[] { 1, 2, 3, 4, 5 }), "Input: {1, 2, 3, 4, 5} ");
            Assert.AreEqual(true, exercises.ArrayFront9(new int[] { 9, 2, 3 }), "Input: {9, 2, 3} ");
            Assert.AreEqual(true, exercises.ArrayFront9(new int[] { 1, 9, 9 }), "Input: {1, 9, 9} ");
            Assert.AreEqual(false, exercises.ArrayFront9(new int[] { 1, 2, 3 }), "Input: {1, 2, 3} ");
            Assert.AreEqual(true, exercises.ArrayFront9(new int[] { 1, 9 }), "Input: {1, 9} ");
            Assert.AreEqual(false, exercises.ArrayFront9(new int[] { 5, 5 }), "Input: {5, 5 } ");
            Assert.AreEqual(false, exercises.ArrayFront9(new int[] { 2 }), "Input: { 2 } ");
            Assert.AreEqual(true, exercises.ArrayFront9(new int[] { 9 }), "Input: { 9 } ");
            Assert.AreEqual(false, exercises.ArrayFront9(new int[] { }), "Input: { } ");
            Assert.AreEqual(true, exercises.ArrayFront9(new int[] { 3, 9, 2, 3, 3 }), "Input: { 3, 9, 2, 3, 3 } ");

        }

        /*
         array123([1, 1, 2, 3, 1]) → true
         array123([1, 1, 2, 4, 1]) → false
         array123([1, 1, 2, 1, 2, 3]) → true
         */
        [TestMethod]
        public void array123()
        {
            Assert.AreEqual(true, exercises.Array123(new int[] { 1, 1, 2, 3, 1 }));
            Assert.AreEqual(false, exercises.Array123(new int[] { 1, 1, 2, 4, 1 }));
            Assert.AreEqual(true, exercises.Array123(new int[] { 1, 1, 2, 1, 2, 3 }));
            Assert.AreEqual(false, exercises.Array123(new int[] { 1, 1, 2, 1, 2, 1 }));
            Assert.AreEqual(true, exercises.Array123(new int[] { 1, 2, 3, 1, 2, 3 }));
            Assert.AreEqual(true, exercises.Array123(new int[] { 1, 2, 3 }));
            Assert.AreEqual(false, exercises.Array123(new int[] { 1, 1, 1 }));
            Assert.AreEqual(false, exercises.Array123(new int[] { 1, 2 }));
            Assert.AreEqual(false, exercises.Array123(new int[] { 1 }));
            Assert.AreEqual(false, exercises.Array123(new int[] { }));

        }

        /*
         noTriples([1, 1, 2, 2, 1]) → true
         noTriples([1, 1, 2, 2, 2, 1]) → false
         noTriples([1, 1, 1, 2, 2, 2, 1]) → false
         */
        [TestMethod]
        public void noTriples()
        {
            Assert.AreEqual(true, exercises.NoTriples(new int[] { 1, 1, 2, 2, 1 }));
            Assert.AreEqual(false, exercises.NoTriples(new int[] { 1, 1, 2, 2, 2, 1 }));
            Assert.AreEqual(false, exercises.NoTriples(new int[] { 1, 1, 1, 2, 2, 2, 1 }));
            Assert.AreEqual(true, exercises.NoTriples(new int[] { 1, 1, 2, 2, 1, 2, 1 }));
            Assert.AreEqual(true, exercises.NoTriples(new int[] { 1, 2, 1 }));
            Assert.AreEqual(false, exercises.NoTriples(new int[] { 1, 1, 1 }));
            Assert.AreEqual(true, exercises.NoTriples(new int[] { 1, 1 }));
            Assert.AreEqual(true, exercises.NoTriples(new int[] { 1 }));
            Assert.AreEqual(true, exercises.NoTriples(new int[] { }));
        }

        /*
         makeEnds([1, 2, 3]) → [1, 3]
         makeEnds([1, 2, 3, 4]) → [1, 4]
         makeEnds([7, 4, 6, 2]) → [7, 2]
         */
        [TestMethod]
        public void makeEnds()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3 }, exercises.MakeEnds(new int[] { 1, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 1, 4 }, exercises.MakeEnds(new int[] { 1, 2, 3, 4 }));
            CollectionAssert.AreEqual(new int[] { 7, 2 }, exercises.MakeEnds(new int[] { 7, 4, 6, 2 }));

            CollectionAssert.AreEqual(new int[] { 1, 3 }, exercises.MakeEnds(new int[] { 1, 2, 2, 2, 2, 2, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 7, 4 }, exercises.MakeEnds(new int[] { 7, 4 }));
            CollectionAssert.AreEqual(new int[] { 7, 7 }, exercises.MakeEnds(new int[] { 7 }));
            CollectionAssert.AreEqual(new int[] { 5, 9 }, exercises.MakeEnds(new int[] { 5, 2, 9 }));
            CollectionAssert.AreEqual(new int[] { 2, 1 }, exercises.MakeEnds(new int[] { 2, 3, 4, 1 }));

        }

        /*
         has23([2, 5]) → true
         has23([4, 3]) → true
         has23([4, 5]) → false
         */
        [TestMethod]
        public void has23()
        {
            Assert.AreEqual(true, exercises.Has23(new int[] { 2, 5 }));
            Assert.AreEqual(true, exercises.Has23(new int[] { 4, 3 }));
            Assert.AreEqual(false, exercises.Has23(new int[] { 4, 5 }));

            Assert.AreEqual(true, exercises.Has23(new int[] { 2, 2 }));
            Assert.AreEqual(true, exercises.Has23(new int[] { 3, 2 }));
            Assert.AreEqual(true, exercises.Has23(new int[] { 3, 3 }));
            Assert.AreEqual(false, exercises.Has23(new int[] { 7, 7 }));
            Assert.AreEqual(true, exercises.Has23(new int[] { 3, 9 }));
            Assert.AreEqual(false, exercises.Has23(new int[] { 9, 5 }));



        }

        /*
         no23([4, 5]) → true
         no23([4, 2]) → false
         no23([3, 5]) → false
         */
        [TestMethod]
        public void no23()
        {
            Assert.AreEqual(true, exercises.No23(new int[] { 4, 5 }));
            Assert.AreEqual(false, exercises.No23(new int[] { 4, 2 }));
            Assert.AreEqual(false, exercises.No23(new int[] { 3, 5 }));

            Assert.AreEqual(true, exercises.No23(new int[] { 1, 9 }));
            Assert.AreEqual(false, exercises.No23(new int[] { 2, 9 }));
            Assert.AreEqual(false, exercises.No23(new int[] { 1, 3 }));
            Assert.AreEqual(true, exercises.No23(new int[] { 1, 1 }));
            Assert.AreEqual(false, exercises.No23(new int[] { 2, 2 }));
            Assert.AreEqual(false, exercises.No23(new int[] { 3, 3 }));
            Assert.AreEqual(true, exercises.No23(new int[] { 7, 8 }));
            Assert.AreEqual(true, exercises.No23(new int[] { 8, 7 }));


        }

        /*
         makeLast([4, 5, 6]) → [0, 0, 0, 0, 0, 6]
         makeLast([1, 2]) → [0, 0, 0, 2]
         makeLast([3]) → [0, 3]
         */
        [TestMethod]
        public void makeLast()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 6 }, exercises.MakeLast(new int[] { 4, 5, 6 }));
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 2 }, exercises.MakeLast(new int[] { 1, 2 }));
            CollectionAssert.AreEqual(new int[] { 0, 3 }, exercises.MakeLast(new int[] { 3 }));


            CollectionAssert.AreEqual(new int[] { 0, 0 }, exercises.MakeLast(new int[] { 0 }));
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 7 }, exercises.MakeLast(new int[] { 7, 7, 7 }));
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 4 }, exercises.MakeLast(new int[] { 3, 1, 4 }));
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 0, 0, 4 }, exercises.MakeLast(new int[] { 1, 2, 3, 4 }));
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }, exercises.MakeLast(new int[] { 1, 2, 3, 0 }));
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 4 }, exercises.MakeLast(new int[] { 2, 4 }));

        }

        /*
         double23([2, 2]) → true
         double23([3, 3]) → true
         double23([2, 3]) → false
         */
        [TestMethod]
        public void double23()
        {
            Assert.AreEqual(true, exercises.Double23(new int[] { 2, 2 }));
            Assert.AreEqual(true, exercises.Double23(new int[] { 3, 3 }));
            Assert.AreEqual(false, exercises.Double23(new int[] { 2, 3 }));

            Assert.AreEqual(false, exercises.Double23(new int[] { 3, 2 }));
            Assert.AreEqual(false, exercises.Double23(new int[] { 4, 5 }));
            Assert.AreEqual(false, exercises.Double23(new int[] { 2 }));
            Assert.AreEqual(false, exercises.Double23(new int[] { 3 }));
            Assert.AreEqual(false, exercises.Double23(new int[] { }));
            Assert.AreEqual(false, exercises.Double23(new int[] { 3, 4 }));


        }

        /*
         fix23([1, 2, 3]) → [1, 2, 0]
         fix23([2, 3, 5]) → [2, 0, 5]
         fix23([1, 2, 1]) → [1, 2, 1]
         */
        [TestMethod]
        public void fix23()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 0 }, exercises.Fix23(new int[] { 1, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 2, 0, 5 }, exercises.Fix23(new int[] { 2, 3, 5 }));
            CollectionAssert.AreEqual(new int[] { 1, 2, 1 }, exercises.Fix23(new int[] { 1, 2, 1 }));

            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, exercises.Fix23(new int[] { 3, 2, 1 }));
            CollectionAssert.AreEqual(new int[] { 2, 2, 0 }, exercises.Fix23(new int[] { 2, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 2, 0, 3 }, exercises.Fix23(new int[] { 2, 3, 3 }));

        }

        /*
         start1([1, 2, 3], [1, 3]) → 2
         start1([7, 2, 3], [1]) → 1
         start1([1, 2], []) → 1
         */
        [TestMethod]
        public void start1()
        {
            Assert.AreEqual(2, exercises.Start1(new int[] { 1, 2, 3 }, new int[] { 1, 3 }));
            Assert.AreEqual(1, exercises.Start1(new int[] { 7, 2, 3 }, new int[] { 1 }));
            Assert.AreEqual(1, exercises.Start1(new int[] { 1, 2 }, new int[] { }));

            Assert.AreEqual(1, exercises.Start1(new int[] { }, new int[] { 1, 2 }));
            Assert.AreEqual(0, exercises.Start1(new int[] { 7 }, new int[] { }));
            Assert.AreEqual(1, exercises.Start1(new int[] { 7 }, new int[] { 1 }));
            Assert.AreEqual(2, exercises.Start1(new int[] { 1 }, new int[] { 1 }));
            Assert.AreEqual(0, exercises.Start1(new int[] { 7 }, new int[] { 8 }));
            Assert.AreEqual(0, exercises.Start1(new int[] { }, new int[] { }));
            Assert.AreEqual(2, exercises.Start1(new int[] { 1, 3 }, new int[] { 1 }));
        }

        /*
         biggerTwo([1, 2], [3, 4]) → [3, 4]
         biggerTwo([3, 4], [1, 2]) → [3, 4]
         biggerTwo([1, 1], [1, 2]) → [1, 2]
         */
        [TestMethod]
        public void biggerTwo()
        {
            CollectionAssert.AreEqual(new int[] { 3, 4 }, exercises.BiggerTwo(new int[] { 1, 2 }, new int[] { 3, 4 }));
            CollectionAssert.AreEqual(new int[] { 3, 4 }, exercises.BiggerTwo(new int[] { 3, 4 }, new int[] { 1, 2 }));
            CollectionAssert.AreEqual(new int[] { 1, 2 }, exercises.BiggerTwo(new int[] { 1, 1 }, new int[] { 1, 2 }));

            CollectionAssert.AreEqual(new int[] { 2, 1 }, exercises.BiggerTwo(new int[] { 2, 1 }, new int[] { 1, 1 }));
            CollectionAssert.AreEqual(new int[] { 2, 2 }, exercises.BiggerTwo(new int[] { 2, 2 }, new int[] { 1, 3 }));
            CollectionAssert.AreEqual(new int[] { 1, 3 }, exercises.BiggerTwo(new int[] { 1, 3 }, new int[] { 2, 2 }));
            CollectionAssert.AreEqual(new int[] { 6, 7 }, exercises.BiggerTwo(new int[] { 6, 7 }, new int[] { 3, 1 }));

        }

        /*
         makeMiddle([1, 2, 3, 4]) → [2, 3]
         makeMiddle([7, 1, 2, 3, 4, 9]) → [2, 3]
         makeMiddle([1, 2]) → [1, 2]
         */
        [TestMethod]
        public void makeMiddle()
        {
            CollectionAssert.AreEqual(new int[] { 2, 3 }, exercises.MakeMiddle(new int[] { 1, 2, 3, 4 }));
            CollectionAssert.AreEqual(new int[] { 2, 3 }, exercises.MakeMiddle(new int[] { 7, 1, 2, 3, 4, 9 }));
            CollectionAssert.AreEqual(new int[] { 1, 2 }, exercises.MakeMiddle(new int[] { 1, 2 }));

            CollectionAssert.AreEqual(new int[] { 2, 4 }, exercises.MakeMiddle(new int[] { 5, 2, 4, 7 }));
            CollectionAssert.AreEqual(new int[] { 4, 3 }, exercises.MakeMiddle(new int[] { 9, 0, 4, 3, 9, 1 }));

        }

        /*
         plusTwo([1, 2], [3, 4]) → [1, 2, 3, 4]
         plusTwo([4, 4], [2, 2]) → [4, 4, 2, 2]
         plusTwo([9, 2], [3, 4]) → [9, 2, 3, 4]
         */
        [TestMethod]
        public void plusTwo()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, exercises.PlusTwo(new int[] { 1, 2 }, new int[] { 3, 4 }));
            CollectionAssert.AreEqual(new int[] { 4, 4, 2, 2 }, exercises.PlusTwo(new int[] { 4, 4 }, new int[] { 2, 2 }));
            CollectionAssert.AreEqual(new int[] { 9, 2, 3, 4 }, exercises.PlusTwo(new int[] { 9, 2 }, new int[] { 3, 4 }));
        }

        /*
         swapEnds([1, 2, 3, 4]) → [4, 2, 3, 1]
         swapEnds([1, 2, 3]) → [3, 2, 1]
         swapEnds([8, 6, 7, 9, 5]) → [5, 6, 7, 9, 8]
         */
        [TestMethod]
        public void swapEnds()
        {
            CollectionAssert.AreEqual(new int[] { 4, 2, 3, 1 }, exercises.SwapEnds(new int[] { 1, 2, 3, 4 }));
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, exercises.SwapEnds(new int[] { 1, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 5, 6, 7, 9, 8 }, exercises.SwapEnds(new int[] { 8, 6, 7, 9, 5 }));

            CollectionAssert.AreEqual(new int[] { 9, 1, 4, 1, 5, 3 }, exercises.SwapEnds(new int[] { 3, 1, 4, 1, 5, 9 }));
            CollectionAssert.AreEqual(new int[] { 2, 1 }, exercises.SwapEnds(new int[] { 1, 2 }));
            CollectionAssert.AreEqual(new int[] { 1 }, exercises.SwapEnds(new int[] { 1 }));

        }

        /*
         more14([1, 4, 1]) → true
         more14([1, 4, 1, 4]) → false
         more14([1, 1]) → true
         */
        [TestMethod]
        public void more14()
        {
            Assert.AreEqual(true, exercises.More14(new int[] { 1, 4, 1 }));
            Assert.AreEqual(false, exercises.More14(new int[] { 1, 4, 1, 4 }));
            Assert.AreEqual(true, exercises.More14(new int[] { 1, 1 }));

            Assert.AreEqual(true, exercises.More14(new int[] { 1, 6, 6 }));
            Assert.AreEqual(true, exercises.More14(new int[] { 1 }));
            Assert.AreEqual(false, exercises.More14(new int[] { 1, 4 }));
            Assert.AreEqual(true, exercises.More14(new int[] { 6, 1, 1 }));
            Assert.AreEqual(false, exercises.More14(new int[] { 1, 6, 4 }));
            Assert.AreEqual(true, exercises.More14(new int[] { 1, 1, 4, 4, 1 }));
            Assert.AreEqual(true, exercises.More14(new int[] { 1, 1, 6, 4, 4, 1 }));
            Assert.AreEqual(false, exercises.More14(new int[] { }));
            Assert.AreEqual(false, exercises.More14(new int[] { 4, 1, 4, 6 }));
            Assert.AreEqual(false, exercises.More14(new int[] { 4, 1, 4, 6, 1 }));
            Assert.AreEqual(true, exercises.More14(new int[] { 1, 4, 1, 4, 1, 6 }));



        }

        /*
         fizzArray(4) → [0, 1, 2, 3]
         fizzArray(1) → [0]
         fizzArray(10) → [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
         */
        [TestMethod]
        public void fizzArray()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1, 2, 3 }, exercises.FizzArray(4));
            CollectionAssert.AreEqual(new int[] { 0 }, exercises.FizzArray(1));
            CollectionAssert.AreEqual(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, exercises.FizzArray(10));

            CollectionAssert.AreEqual(new int[] { }, exercises.FizzArray(0));
            CollectionAssert.AreEqual(new int[] { 0, 1 }, exercises.FizzArray(2));
            CollectionAssert.AreEqual(new int[] { 0, 1, 2, 3, 4, 5, 6 }, exercises.FizzArray(7));

        }

        /*
         only14([1, 4, 1, 4]) → true
         only14([1, 4, 2, 4]) → false
         only14([1, 1]) → true
         */
        [TestMethod]
        public void only14()
        {
            Assert.AreEqual(true, exercises.Only14(new int[] { 1, 4, 1, 4 }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 1, 4, 2, 4 }));
            Assert.AreEqual(true, exercises.Only14(new int[] { 1, 1 }));

            Assert.AreEqual(true, exercises.Only14(new int[] { 4, 1 }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 2 }));
            Assert.AreEqual(true, exercises.Only14(new int[] { }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 1, 4, 1, 3 }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 3, 1, 3 }));
            Assert.AreEqual(true, exercises.Only14(new int[] { 1 }));
            Assert.AreEqual(true, exercises.Only14(new int[] { 4 }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 3, 4 }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 1, 3, 4 }));
            Assert.AreEqual(true, exercises.Only14(new int[] { 1, 1, 1 }));
            Assert.AreEqual(false, exercises.Only14(new int[] { 1, 1, 1, 5 }));
            Assert.AreEqual(true, exercises.Only14(new int[] { 4, 1, 4, 1 }));

        }

        
    /*
     no14([1, 2, 3]) → true
     no14([1, 2, 3, 4]) → false
     no14([2, 3, 4]) → true
     */
        [TestMethod]
        public void no14()
        {
            Assert.AreEqual(true, exercises.No14(new int[] { 1, 2, 3 }), "no14(new int[]{1, 2, 3})");
            Assert.AreEqual(false, exercises.No14(new int[] { 1, 2, 3, 4 }), "no14(new int[]{1, 2, 3, 4})");
            Assert.AreEqual(true, exercises.No14(new int[] { 2, 3, 4 }), "no14(new int[]{2, 3, 4})");
        }

        /*
         has12([1, 3, 2]) → true
         has12([3, 1, 2]) → true
         has12([3, 1, 4, 5, 2]) → true
         */
        [TestMethod]
        public void has12()
        {
            Assert.AreEqual(true, exercises.Has12(new int[] { 1, 3, 2 }), "has12(new int[]{1, 3, 2})");
            Assert.AreEqual(true, exercises.Has12(new int[] { 3, 1, 2 }), "has12(new int[]{3, 1, 2})");
            Assert.AreEqual(true, exercises.Has12(new int[] { 3, 1, 4, 5, 2 }), "has12(new int[]{3, 1, 4, 5, 2})");
            Assert.AreEqual(false, exercises.Has12(new int[] { 3, 2, 1 }), "has12(new int[]{3, 2, 1})");
            Assert.AreEqual(false, exercises.Has12(new int[] { 3, 1, 4 }), "has12(new int[]{3, 1, 4})");
            Assert.AreEqual(false, exercises.Has12(new int[] { 3, 5, 2 }), "has12(new int[]{3, 5, 2})");
            Assert.AreEqual(false, exercises.Has12(new int[] { 5, 5, 5 }), "has12(new int[]{5, 5, 5})");
            Assert.AreEqual(true, exercises.Has12(new int[] { 2, 1, 2 }), "has12(new int[]{2, 1, 2})");
        }

        /*
         fizzArray3(5, 10) → [5, 6, 7, 8, 9]
         fizzArray3(11, 18) → [11, 12, 13, 14, 15, 16, 17]
         fizzArray3(1, 3) → [1, 2]
         */
        [TestMethod]
        public void fizzArray3()
        {

            CollectionAssert.AreEqual(new int[] { 5, 6, 7, 8, 9 }, exercises.FizzArray3(5, 10), "fizzArray3(5, 10)");
            CollectionAssert.AreEqual(new int[] { 11, 12, 13, 14, 15, 16, 17 }, exercises.FizzArray3(11, 18), "fizzArray3(11, 18)");
            CollectionAssert.AreEqual(new int[] { 1, 2 }, exercises.FizzArray3(1, 3), "fizzArray3(1, 3)");
            CollectionAssert.AreEqual(new int[] { }, exercises.FizzArray3(3, 3), "fizzArray3(3, 3)");

        }

        /*
         lessBy10(1, 7, 11) → true
         lessBy10(1, 7, 10) → false
         lessBy10(11, 1, 7) → true
         */
        [TestMethod]
        public void lessBy10()
        {
            Assert.AreEqual(true, exercises.LessBy10(1, 7, 11), "lessBy10(1, 7, 11)");
            Assert.AreEqual(false, exercises.LessBy10(1, 7, 10), "lessBy10(1, 7, 10)");
            Assert.AreEqual(true, exercises.LessBy10(11, 1, 7), "lessBy10(11, 1, 7)");
            Assert.AreEqual(true, exercises.LessBy10(1, 11, 7), "lessBy10(1, 11, 7)");
            Assert.AreEqual(true, exercises.LessBy10(7, 1, 11), "lessBy10(7, 1, 11)");
            Assert.AreEqual(true, exercises.LessBy10(15, 2, 30), "lessBy10(15, 2, 30)");
        }

        /*
         greenTicket(1, 2, 3) → 0
         greenTicket(2, 2, 2) → 20
         greenTicket(1, 1, 2) → 10
         */
        [TestMethod]
        public void greenTicket()
        {
            Assert.AreEqual(0, exercises.GreenTicket(1, 2, 3), "greenTicket(1, 2, 3)");
            Assert.AreEqual(20, exercises.GreenTicket(2, 2, 2), "greenTicket(2, 2, 2)");
            Assert.AreEqual(10, exercises.GreenTicket(1, 1, 2), "greenTicket(1, 1, 2)");
            Assert.AreEqual(10, exercises.GreenTicket(2, 1, 1), "greenTicket(2, 1, 1)");
            Assert.AreEqual(10, exercises.GreenTicket(1, 2, 1), "greenTicket(1, 2, 1)");
        }

        /*
         blackjack(19, 21) → 21
         blackjack(21, 19) → 21
         blackjack(19, 22) → 19
         */
        [TestMethod]
        public void blackjack()
        {
            Assert.AreEqual(21, exercises.Blackjack(19, 21), "blackjack(19, 21)");
            Assert.AreEqual(21, exercises.Blackjack(21, 19), "blackjack(21, 19)");
            Assert.AreEqual(19, exercises.Blackjack(19, 22), "blackjack(19, 22)");
            Assert.AreEqual(19, exercises.Blackjack(22, 19), "blackjack(22, 19)");
            Assert.AreEqual(0, exercises.Blackjack(23, 22), "blackjack(23, 22)");
            Assert.AreEqual(0, exercises.Blackjack(23, 22), "blackjack(10, 12)");
            Assert.AreEqual(21, exercises.Blackjack(21, 21), "blackjack(21, 21)");
            Assert.AreEqual(17, exercises.Blackjack(17, 17), "blackjack(17, 17)");
        }

        /*
         evenlySpaced(2, 4, 6) → true
         evenlySpaced(4, 6, 2) → true
         evenlySpaced(4, 6, 3) → false
         */
        [TestMethod]
        public void evenlySpaced()
        {
            Assert.AreEqual(true, exercises.EvenlySpaced(2, 4, 6), "evenlySpaced(2, 4, 6)");
            Assert.AreEqual(true, exercises.EvenlySpaced(4, 6, 2), "evenlySpaced(4, 6, 2)");
            Assert.AreEqual(false, exercises.EvenlySpaced(4, 6, 3), "evenlySpaced(4, 6, 3)");
            Assert.AreEqual(true, exercises.EvenlySpaced(6, 2, 4), "evenlySpaced(6, 2, 4)");
        }
    }
}
