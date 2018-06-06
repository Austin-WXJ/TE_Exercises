using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests //class name should match
    {
        [TestMethod]
        public void WordCount()//rename to GetCountTest
        {
            WordCount myWordCount = new WordCount();

            //Test1
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"ba", 2 }, {"black", 1 }, { "sheep", 1 }
            };
            Dictionary<string, int> actual = myWordCount.GetCount(new string[]
            {
                "ba", "ba", "black", "sheep"
            });
            CollectionAssert.AreEqual(expected, actual);

            //Test2
            expected = new Dictionary<string, int>()
            {
                {"b", 2 }, {"c", 1 }, { "a", 2 }
            };
            actual = myWordCount.GetCount(new string[]
            {
                "a", "b", "a", "c", "b"
            });
            CollectionAssert.AreEquivalent(expected, actual);

            //Test3
            expected = new Dictionary<string, int>()
            {
            };
            actual = myWordCount.GetCount(new string[]
            {
            });
            CollectionAssert.AreEqual(expected, actual);

            //Test4
            expected = new Dictionary<string, int>()
            {
                { "b", 1 }, {"c", 1 }, {"a", 1 }
            };
            actual = myWordCount.GetCount(new string[]
            {
                "c", "b", "a"
            });
            CollectionAssert.AreEquivalent(expected, actual);

        }

    }
}

