using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laboratornay2_1_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratornay2_1_.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void Triangle_right()
        {
            var a = 3;
            var b = 4;
            var c = 5;

            var result = Logic.GetResult(a, b, c);

            Assert.AreEqual("Треугольник прямоугольный", result);
        }

        [TestMethod()]
        public void Tringle_fl_right()
        {
            var a = 5;
            var b = 6;
            var c = 8;

            var result = Logic.GetResult(a, b, c);

            Assert.AreEqual("Треугольник не прямоугольный", result);
        }

        [TestMethod()]
        public void Not_Tringle()
        {
            var a = 4;
            var b = 5;
            var c = 10;

            var result = Logic.GetResult(a, b, c);

            Assert.AreEqual("Треугольник не существует", result);
        }
    }
}