using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class MissingIntegerUnitTest
    {
        [TestMethod]
        public void MissingIntegerTestMethod1()
        {
            int[] A = { 1, 3, 6, 4, 1, 2};

            Assert.AreEqual(MissingInteger.Solution(A), 5);
        }
    }
}
