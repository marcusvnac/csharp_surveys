using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.Codility;

namespace UnitTest.Codility
{
    [TestClass]
    public class DominatorUnitTest
    {
        [TestMethod]
        public void DominatorTestMethod1()
        {
            int[] A = { 3, 4, 3, 2, 3, -1, 3, 3 };

            Assert.AreEqual(0, Dominator.Solution(A));
        }

        [TestMethod]
        public void DominatorTestMethod2()
        {
            int[] A = { 1, 2, 3, 4, 5, 5, 6 };

            Assert.AreEqual(-1, Dominator.Solution(A));
        }

        [TestMethod]
        public void DominatorTestMethod3()
        {
            int[] A = { 1, 1, 1, 4, 5, 5, 6, 7 };

            Assert.AreEqual(-1, Dominator.Solution(A));
        }

        [TestMethod]
        public void DominatorTestMethod4()
        {
            int[] A = { 1, int.MaxValue, 1, 4, 5, int.MaxValue, 6, 7 };

            Assert.AreEqual(-1, Dominator.Solution(A));
        }


        [TestMethod]
        public void DominatorTestMethod5()
        {
            int[] A = { 0 };

            Assert.AreEqual(0, Dominator.Solution(A));
        }

        [TestMethod]
        public void DominatorTestMethod6()
        {
            int[] A = { };

            Assert.AreEqual(-1, Dominator.Solution(A));
        }

        [TestMethod]
        public void DominatorTestMethod7()
        {
            int[] A = { 1, 1, 1, 1, 2, 2, 2, 2, 2 };

            Assert.AreEqual(4, Dominator.Solution(A));
        }
    }
}
