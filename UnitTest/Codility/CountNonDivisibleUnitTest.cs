using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.Codility;

namespace UnitTest.Codility
{
    [TestClass]
    public class CountNonDivisibleUnitTest
    {
        [TestMethod]
        public void CountNonDivisibleTestMethod1()
        {
            int[] A = { 3, 1, 2, 3, 6 };
            int[] expectedResult = { 2, 4, 3, 2, 0 };

            Assert.IsTrue(expectedResult.SequenceEqual(CountNonDivisible.Solution(A)));
        }
    }
}
