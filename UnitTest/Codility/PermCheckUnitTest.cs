using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class PermCheckUnitTest
    {
        [TestMethod]
        public void PermCheckUnitTestMethod1()
        {
            int[] A = { 4, 1, 3, 2 };

            Assert.AreEqual(PermCheck.Solution(A), 1);
        }

        [TestMethod]
        public void PermCheckUnitTestMethod2()
        {
            int[] A = { 4, 1, 3 };

            Assert.AreEqual(PermCheck.Solution(A), 0);
        }

    }
}
