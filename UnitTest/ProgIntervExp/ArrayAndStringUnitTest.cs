using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSurveys.ProgIntervExp;

namespace UnitTest.ProgIntervExp
{
    [TestClass]
    public class ArrayAndStringUnitTest
    {
        [TestMethod]
        public void FirstNonRepeteadTestMethod1()
        {
            string str = "total";

            Assert.AreEqual('o', ArrayAndStrings.FirstNonRepeated(str));
        }

        [TestMethod]
        public void RemoveCharsTestMethod1()
        {
            string str = "Battle of the Vowels: Hawaii vs. Grozny";
            string remove = "aeiou";
            string result = "Bttl f th Vwls: Hw vs. Grzny";

            Assert.AreEqual(result, ArrayAndStrings.RemoveChars(str, remove));
        }

        [TestMethod]
        public void ReverseStringTestMethod1()
        {
            string str = "Do or do not, there is no try.";
            string result = "try. no is there not, do or Do";

            string returnStr = new string(ArrayAndStrings.ReverseWords(str.ToCharArray()));

            Assert.AreEqual(result, returnStr);
        }
    }
}

