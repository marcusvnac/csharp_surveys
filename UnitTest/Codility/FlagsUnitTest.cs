using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.Codility;

namespace UnitTest.Codility
{
    [TestClass]
    public class FlagsUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] A = { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };

            Assert.AreEqual(3, Flags.Solution(A));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] A = { 1, 2, 3, 4, 1000000000 };

            Assert.AreEqual(0, Flags.Solution(A));
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] A = { 1000000000, 999999999, 999999998, 4 };

            Assert.AreEqual(0, Flags.Solution(A));
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] A = { 10, 10 };

            Assert.AreEqual(0, Flags.Solution(A));
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] A = { 10 };

            Assert.AreEqual(0, Flags.Solution(A));
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] A = { 6, 2, 2, 7 };

            Assert.AreEqual(0, Flags.Solution(A));
        }

        [TestMethod]
        public void TestMethod7()
        {
            int[] A = { 0, 7, 7, 1 };

            Assert.AreEqual(0, Flags.Solution(A));
        }

        [TestMethod]
        public void TestMethod8()
        {
            int[] A = { 10, 9, 8 };

            Assert.AreEqual(0, Flags.Solution(A));
        }
        [TestMethod]
        public void TestMethod9()
        {
            int[] A = { 10, 80 };

            Assert.AreEqual(0, Flags.Solution(A));
        }
    }
}
