using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.Codility;

namespace UnitTest.Codility
{
    [TestClass]
    public class NailingPlanksUnitTets
    {
        [TestMethod]
        public void NailingPlanksTestMethod1()
        {
            int[] A = { 1, 4, 5, 8 };
            int[] B = { 4, 5, 9, 10 };
            int[] C = { 4, 6, 7, 10, 2 };

            Assert.AreEqual(4, NailingPlanks.Solution(A, B, C));
        }

        [TestMethod]
        public void NailingPlanksTestMethod2()
        {
            int[] A = { 1, 4, 5, 8 };
            int[] B = { 4, 5, 9, 10 };
            int[] C = { 50, 250, 9898 };

            Assert.AreEqual(-1, NailingPlanks.Solution(A, B, C));
        }


        [TestMethod]
        public void NailingPlanksTestMethod3()
        {
            int[] A = { 1, 4, 5, 8 };
            int[] B = { 4, 5, 9, 10 };
            int[] C = { 4, 4, 4, 5, 5, 7 };

            Assert.AreEqual(-1, NailingPlanks.Solution(A, B, C));
        }

        [TestMethod]
        public void NailingPlanksTestMethod4()
        {
            int[] A = { 1, 4, 5, 8 };
            int[] B = { 4, 5, 9, 10 };
            int[] C = { 4, 4, 4, 5, 5, 7, 9 };

            Assert.AreEqual(3, NailingPlanks.Solution(A, B, C));
        }

        [TestMethod]
        public void NailingPlanksTestMethod5()
        {
            int[] A = { 1, 4, 5, 8 };
            int[] B = { 4, 5, 9, 10 };
            int[] C = { 4, 4, 4, 5, 5, 5, 5, 7, 9 };

            Assert.AreEqual(3, NailingPlanks.Solution(A, B, C));
        }

        [TestMethod]
        public void NailingPlanksTestMethod6()
        {
            int[] A = { 1 };
            int[] B = { 4 };
            int[] C = { 5 };

            Assert.AreEqual(-1, NailingPlanks.Solution(A, B, C));
        }

        [TestMethod]
        public void NailingPlanksTestMethod7()
        {
            int[] A = { 1, 4, 5, 8 };
            int[] B = { 4, 5, 9, 10 };
            int[] C = { 4, 4, 4, 5, 5, 5, 5, 7, 9, 9, 1, 3};

            Assert.AreEqual(4, NailingPlanks.Solution(A, B, C));
        }

        [TestMethod]
        public void NailingPlanksTestMethod8()
        {
            int[] A = { 1, 4, 5, 8 };
            int[] B = { 1, 4, 5, 8 };
            int[] C = { 4, 4, 4, 5, 5, 5, 5, 7, 9, 9, 1, 3, 8 };

            Assert.AreEqual(4, NailingPlanks.Solution(A, B, C));
        }

        [TestMethod]
        public void NailingPlanksTestMethod9()
        {
            int[] A = { 1, 4, 5, 8 };
            int[] B = { 4, 5, 9, 10 };
            int[] C = { 4 };

            Assert.AreEqual(-1, NailingPlanks.Solution(A, B, C));
        }

        [TestMethod]
        public void NailingPlanksTestMethod10()
        {
            int[] A = { 1, 5, 6, 50 };
            int[] B = { 3, 7, 30, 70 };
            int[] C = { 2, 4, 6, 9, 60 };

            Assert.AreEqual(3, NailingPlanks.Solution(A, B, C));
        }
    }
}
