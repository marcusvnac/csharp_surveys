using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.Codility;

namespace UnitTest.Codility
{
    [TestClass]
    public class StoneWallUnitTest
    {
        [TestMethod]
        public void StoneWallTestMethod1()
        {
            int[] H = { 8, 8, 5, 7, 9, 8, 7, 4, 8 };

            Assert.AreEqual(7, StoneWall.Solution(H));
        }
    }
}
