using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class MaxProductOfThreeUnitTest
    {
        [TestMethod]
        public void MaxProductOfThreeTestMethod1()
        {
            int[] A = { -3, 1, 2, -2, 5, 6 };

            Assert.AreEqual(60, MaxProductOfThree.Solution(A));
        }

        [TestMethod]
        public void MaxProductOfThreeTestMethod2()
        {
            int[] A = { 0, -1, -2, -3, -4, -5 };

            Assert.AreEqual(0, MaxProductOfThree.Solution(A));
        }

        [TestMethod]
        public void MaxProductOfThreeTestMethod3()
        {
            int[] A = { 3, 3, 3, 3, 3, 3 };

            Assert.AreEqual(27, MaxProductOfThree.Solution(A));
        }

        [TestMethod]
        public void MaxProductOfThreeTestMethod4()
        {
            int[] A = { 1000, 1000, 1000, 1000, 1000, 1000 };

            Assert.AreEqual(1000000000, MaxProductOfThree.Solution(A));
        }

        [TestMethod]
        public void MaxProductOfThreeTestMethod5()
        {
            int[] A = { 1000, 1000, -1000, -1000, -1000, -1000 };

            Assert.AreEqual(-1000000000, MaxProductOfThree.Solution(A));
        }
    }
}
