using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba_2_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_2_2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void Wordtest()
        {
            var first = "fghr";
            var second = "fkdm";

            var result = Logic.GetResult(first, second);

            Assert.AreEqual("да нет нет нет ", result);
        }

        [TestMethod()]
        public void Repeatcharacters()
        {
            var first = "dffr";
            var second = "fkom";

            var result = Logic.GetResult(first, second);

            Assert.AreEqual("нет да нет ", result);
        }

    }
}