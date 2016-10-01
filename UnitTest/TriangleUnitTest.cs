using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void TriangleTestMethod1()
        {
            int[] A = { 10, 2, 5, 1, 8, 20 };

            Assert.AreEqual(1, Triangle.Solution(A));
        }

        [TestMethod]
        public void TriangleTestMethod2()
        {
            int[] A = { 10, 50, 5, 1 };

            Assert.AreEqual(0, Triangle.Solution(A));
        }


        [TestMethod]
        public void TriangleTestMethod3()
        {
            int[] A = { int.MaxValue, int.MaxValue, int.MaxValue };

            Assert.AreEqual(1, Triangle.Solution(A));
        }

        [TestMethod]
        public void TriangleTestMethod4()
        {
            int[] A = { int.MinValue, int.MinValue, int.MinValue };

            Assert.AreEqual(0, Triangle.Solution(A));
        }

        [TestMethod]
        public void TriangleTestMethod5()
        {
            int[] A = { 0, 0, 0 };

            Assert.AreEqual(0, Triangle.Solution(A));
        }
    }
}
