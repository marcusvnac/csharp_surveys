using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class CountDivUnitTest
    {
        [TestMethod]
        public void CountDivUnitTestMethod1()
        {
            int A = 6, B = 11, K = 2;

            Assert.AreEqual(CountDiv.Solution(A, B, K), 3);
        }
    }
}
