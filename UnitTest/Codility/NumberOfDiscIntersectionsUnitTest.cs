using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class NumberOfDiscIntersectionsUnitTest
    {
        [TestMethod]
        public void NumberOfDiscIntersectionsUnitTestTestMethod1()
        {
            int[] A = { 1, 5, 2, 1, 4, 0 };

            Assert.AreEqual(11, NumberOfDiscIntersections.Solution(A));
        }

        [TestMethod]
        public void NumberOfDiscIntersectionsUnitTestTestMethod2()
        {
            int[] A = { 1, 1, 1 };

            Assert.AreEqual(3, NumberOfDiscIntersections.Solution(A));
        }

        [TestMethod]
        public void NumberOfDiscIntersectionsUnitTestTestMethod3()
        {
            int[] A = { 0, 0, 0 };

            Assert.AreEqual(0, NumberOfDiscIntersections.Solution(A));
        }

        [TestMethod]
        public void NumberOfDiscIntersectionsUnitTestTestMethod4()
        {
            int[] A = { 0, 0, 1 };

            Assert.AreEqual(1, NumberOfDiscIntersections.Solution(A));
        }


        [TestMethod]
        public void NumberOfDiscIntersectionsUnitTestTestMethod5()
        {
            int[] A = { 0, 0, 1, 0, 0};

            Assert.AreEqual(3, NumberOfDiscIntersections.Solution(A));
        }
    }
}
