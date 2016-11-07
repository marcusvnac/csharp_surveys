using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class PassingCarsUnitTest
    {
        [TestMethod]
        public void PassingCarsUnitTestMethod1()
        {
            int[] A = { 0, 1 , 0, 1, 1  };

            Assert.AreEqual(PassingCars.Solution(A), 5);
        }
    }
}
