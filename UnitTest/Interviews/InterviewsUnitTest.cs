using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest.Interviews
{
    [TestClass]
    public class InterviewsUnitTest
    {
        [TestMethod]
        public void AmzAbbreviationTestMethod1()
        {
            string input = "AMA";


            List<string> result = CSharpSurveys.Interviews.AmzAbbreviation.Abbreviation(input);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AmzAbbreviationTestMethod2()
        {
            string input = "Amazon";

            List<string> result = CSharpSurveys.Interviews.AmzAbbreviation.Abbreviation2(input);

            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void AmzAbbreviationRecursiceTestMethod1()
        {
            string input = "ama";

            List<string> result = CSharpSurveys.Interviews.AmzAbbreviation.AbbreviationRecursive(input);

            Assert.IsNotNull(result);
        }
    }
}
