using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class GenomicRangeQueryUnitTest
    {
        [TestMethod]
        public void GenomicRangeQueryTestMethod1()
        {
            string S = "CAGCCTA";
            int[] P = { 2, 5, 0 }, Q = { 4, 5, 6 }, res = { 2, 4, 1 };

            Assert.IsTrue(GenomicRangeQuery.Solution(S, P, Q).SequenceEqual(res));
        }

    }
}
