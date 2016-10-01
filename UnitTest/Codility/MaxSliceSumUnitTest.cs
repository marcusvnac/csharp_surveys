using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.Codility;

namespace UnitTest.Codility
{
    [TestClass]
    public class MaxSliceSumUnitTest
    {
        [TestMethod]
        public void MaxSliceSumTestMethod1()
        {
            int[] A = { 3, 2, -6, 4, 0 };

            Assert.AreEqual(5, MaxSliceSum.Solution(A));
        }

        [TestMethod]
        public void MaxSliceSumTestMethod2()
        {
            int[] A = { 3 };

            Assert.AreEqual(3, MaxSliceSum.Solution(A));
        }


        [TestMethod]
        public void MaxSliceSumTestMethod3()
        {
            int[] A = { -10, -20, -5 };

            Assert.AreEqual(-5, MaxSliceSum.Solution(A));
        }
    }
}
