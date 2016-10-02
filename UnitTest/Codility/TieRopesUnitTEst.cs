using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.Codility;

namespace UnitTest.Codility
{
    [TestClass]
    public class TieRopesUnitTest
    {
        [TestMethod]
        public void TieRopesTestMethod1()
        {
            int[] A = { 1, 2, 3, 4, 1, 1, 3 };
            int K = 4;

            Assert.AreEqual(3, TieRopes.Solution(K, A));
        } 
    }
}
