using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class FrogRiverOneUnitTest
    {
        [TestMethod]
        public void FrogRiverOneUnitTestMethod1()
        {
            int[] A = { 1, 3, 1, 4, 2, 3, 5, 4 };

            Assert.AreEqual(FrogRiverOne.Solution(5, A), 6);
        }
    }
}
