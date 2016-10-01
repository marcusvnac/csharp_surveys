using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class OddOccurrencesInArrayTest
    {
        [TestMethod]
        public void SolutionTest1()
        {
            int[] A = { 9, 3, 9, 3, 9, 7, 9 };

            Assert.AreEqual(OddOccurrencesInArray.Solution(A), 7);                
        }
    }
}
