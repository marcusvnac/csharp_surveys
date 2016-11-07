using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.Codility;

namespace UnitTest
{
    [TestClass]
    public class FrogJmpUnitTest
    {
        [TestMethod]
        public void FrogJmpUnitTestMethod1()
        {
            Assert.AreEqual(FrogJmp.Solution(10, 85, 30), 3);
        }
    }
}
