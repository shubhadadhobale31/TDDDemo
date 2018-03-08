using System;
using System.Runtime.Remoting.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDDemo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnAddtionWhenTwoPositiveIntsARePassed()
        {
            Calc c = new Calc();
            int res = c.Add(1, 2);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ReturnAddtionWhenOnePositiveAndOneNegativeIntsARePassed()
        {
            ICalc c = new Calc();
            int res = c.Add(1, -2);
            Assert.AreEqual(3, res);
        }
    }
}
