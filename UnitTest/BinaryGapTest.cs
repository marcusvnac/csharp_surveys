using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class BinaryGapTest
    {
        [TestMethod]
        public void SolutionTest1()
        {
            int testValue = 1041;

            int result = BinaryGap.Solution(testValue);

            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void SolutionTest2()
        {
            int testValue = 15;

            int result = BinaryGap.Solution(testValue);

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void SolutionTest3()
        {
            int testValue = 20;

            int result = BinaryGap.Solution(testValue);

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void SolutionTest4()
        {
            int testValue = 9;

            int result = BinaryGap.Solution(testValue);

            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void SolutionTest5()
        {
            int testValue = 529;

            int result = BinaryGap.Solution(testValue);

            Assert.AreEqual(result, 4);
        }

    }
}
