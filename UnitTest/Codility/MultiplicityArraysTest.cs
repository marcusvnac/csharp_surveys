using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurvey;

namespace UnitTest
{
    [TestClass]
    public class MultiplicityArraysTest
    {
        [TestMethod]
        public void MultiplicityArrays_Test()
        {
            MultiplicityArrays test = new MultiplicityArrays();
            int[] A = { 0, 1, 2, 2, 3, 5 };
            int[] B = { 500000, 500000, 0, 0, 0, 20000 };

            Assert.AreEqual(8, test.Solution(A, B));
        }
    }
}
