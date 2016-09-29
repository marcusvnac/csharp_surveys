using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class CycicRotationTest
    {
        [TestMethod]
        public void SolutionTest0()
        {
            int[] A = { 3, 8, 9, 7, 6 };

            Assert.IsTrue(A.SequenceEqual(CyclicRotation.Solution(A, 0)));
        }

        [TestMethod]
        public void SolutionTest2()
        {
            int[] A = { 3, 8, 9, 7, 6 };
            int[] ExpectedResult = { 8, 9, 7, 6, 3 };

            Assert.IsTrue(ExpectedResult.SequenceEqual(CyclicRotation.Solution(A, 2)));
        }

        [TestMethod]
        public void SolutionTest3()
        {
            int[] A = { 3, 8, 9, 7, 6 };
            int[] ExpectedResult = { 9, 7, 6, 3, 8 };

            Assert.IsTrue(ExpectedResult.SequenceEqual(CyclicRotation.Solution(A, 3)));            
        }

        [TestMethod]
        public void SolutionTest4()
        {
            int[] A = { 3, 8, 9, 7, 6 };
            int[] ExpectedResult = { 7, 6, 3, 8, 9 };

            Assert.IsTrue(ExpectedResult.SequenceEqual(CyclicRotation.Solution(A, 4)));
        }

        [TestMethod]
        public void SolutionTest5()
        {
            int[] A = { 3, 8, 9, 7, 6 };
            int[] ExpectedResult = { 6, 3, 8, 9, 7 };

            Assert.IsTrue(ExpectedResult.SequenceEqual(CyclicRotation.Solution(A, 5)));
        }

        [TestMethod]
        public void SolutionTest6()
        {
            int[] A = { 5, -1000 };
            int[] ExpectedResult = { -1000, 5 };

            Assert.IsTrue(ExpectedResult.SequenceEqual(CyclicRotation.Solution(A, 1)));
        }
    }
}
