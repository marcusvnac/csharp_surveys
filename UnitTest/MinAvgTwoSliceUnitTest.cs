using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class MinAvgTwoSliceUnitTest
    {
        [TestMethod]
        public void MinAvgTwoSliceTestMethod1()
        {
            int[] A = { 4, 2, 2, 5, 1, 5, 8 };

            Assert.AreEqual(1, MinAvgTwoSlice.Solution(A));
        }
    }
}
