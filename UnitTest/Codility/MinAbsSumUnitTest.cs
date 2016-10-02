using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.Codility;

namespace UnitTest.Codility
{
    [TestClass]
    public class MinAbsSumUnitTest
    {
        [TestMethod]
        public void MinAbsSumTestMethod1()
        {
            int[] A = { 1, 5, 2, -2 };

            Assert.AreEqual(0, MinAbsSum.Solution(A));
        }
    }
}
