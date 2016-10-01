using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class PermMissingElemUnitTest
    {
        [TestMethod]
        public void PermMissingElemUnitTestTestMethod1()
        {
            int[] A = { 2, 3, 1, 5 };

            Assert.AreEqual(PermMissingElem.Solution(A), 4);
        }
    }
}
