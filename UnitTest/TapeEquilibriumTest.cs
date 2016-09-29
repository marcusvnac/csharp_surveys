using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class TapeEquilibriumTest
    {
        [TestMethod]
        public void TapeEquilibriumTestMethod1()
        {
            int[] A = { 3, 1, 2, 4, 3 };

            Assert.AreEqual(TapeEquilibrium.Solution(A), 1);
        }
    }
}
