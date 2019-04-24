using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopment;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestParseCommas()
        {
            string testString = "1,5,2,3,4";
            List<int> resultList = new List<int> { 1, 5, 2, 3, 4 };
            CollectionAssert.AreEquivalent(resultList, StringAdder.ParseString(testString));
        }

        [TestMethod]
        public void TestSumString()
        {
            string testString = "2,3,9,7,4";
            int result = 25;
            Assert.AreEqual(result, StringAdder.SumString(testString));
        }

        [TestMethod]
        public void TestPreParseString()
        {
            string testString = ";5;3;2;6";
            List<int> resultList = new List<int> { 5, 3, 2, 6};
            CollectionAssert.AreEquivalent(resultList, StringAdder.ParseString(testString));
        }
    }
}
