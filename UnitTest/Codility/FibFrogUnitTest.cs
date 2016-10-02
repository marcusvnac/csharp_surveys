using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.Codility;

namespace UnitTest.Codility
{
    [TestClass]
    public class FibFrogUnitTest
    {
        [TestMethod]
        public void FibFrogTestMethod1()
        {
            int[] A = { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 };

            Assert.AreEqual(3, FibFrog.Solution(A));
        }
    }
}
