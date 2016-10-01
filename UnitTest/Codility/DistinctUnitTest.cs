using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class DistinctUnitTest
    {
        [TestMethod]
        public void DistinctTestMethod1()
        {
            int[] A = { 2, 1, 1, 2, 3, 1 };

            Assert.AreEqual(3, Distinct.Solution(A));
        }

        [TestMethod]
        public void DistinctTestMethod2()
        {
            int[] A = { };

            Assert.AreEqual(0, Distinct.Solution(A));
        }

        [TestMethod]
        public void DistinctTestMethod3()
        {
            int[] A = { 5 };

            Assert.AreEqual(1, Distinct.Solution(A));
        }

        [TestMethod]
        public void DistinctTestMethod4()
        {
            int[] A = { 1, 1, 1, 1 };

            Assert.AreEqual(1, Distinct.Solution(A));
        }

        [TestMethod]
        public void DistinctTestMethod5()
        {
            int[] A = { 5, 5, 5, 6, 6 };

            Assert.AreEqual(2, Distinct.Solution(A));
        }

        [TestMethod]
        public void DistinctTestMethod6()
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.AreEqual(10, Distinct.Solution(A));
        }

        [TestMethod]
        public void DistinctTestMethod7()
        {
            int[] A = { -1000, 2, 3, 4, 5, 6, 7, 8, 9, 10, -1000 };

            Assert.AreEqual(10, Distinct.Solution(A));
        }
    }
}
