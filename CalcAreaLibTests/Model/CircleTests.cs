using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcAreaLib;
using System;
using System.Collections.Generic;
using System.Text;


namespace CalcAreaLib.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CalcAreaTest()
        {
            double enterData = 3;
            double expected = Math.PI * (enterData*enterData);
            Circle circle = new Circle(3);
            double result = circle.CalcArea();

            Assert.AreEqual(expected, result);
        }
    }
}


