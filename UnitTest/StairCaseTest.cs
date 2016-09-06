using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys;

namespace UnitTest
{
    [TestClass]
    public class StairCaseTest
    {
        [TestMethod]
        public void StairCaseProblem_Test()
        {
           StairCase.StairCaseProblem(6);                      
        }
    }
}
