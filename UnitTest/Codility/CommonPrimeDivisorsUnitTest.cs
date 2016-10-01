using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.Codility;

namespace UnitTest.Codility
{
    [TestClass]
    public class CommonPrimeDivisorsUnitTest
    {
        [TestMethod]
        public void CommonPrimeDivisorsTestMethod1()
        {
            int[] A = { 15, 10, 3 };
            int[] B = { 75, 30, 5 };

            Assert.AreEqual(1, CommonPrimeDivisors.Solution(A, B));
        }

        [TestMethod]
        public void CommonPrimeDivisorsTestMethod2()
        {
            int[] A = { int.MaxValue, 10, 3 };
            int[] B = { int.MaxValue, 30, 5 };

            Assert.AreEqual(1, CommonPrimeDivisors.Solution(A, B));
        }
    }
}
