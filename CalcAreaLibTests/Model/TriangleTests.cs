using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcAreaLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcAreaLib.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void CalcAreaTest()
        {

            double[] enterData = new double[] { 3,3,3};

            double p = .0f;
            for (int i = 0; i < enterData.Length; i++)
            {
                p += enterData[i];
            }
            p /= 2;

            double expected = p;
            for (int i = 0; i < enterData.Length; i++)
            {
                expected *= p - enterData[i];
            }

            expected = Math.Sqrt(expected);

            Triangle triangle = new Triangle(enterData);
            double result = triangle.CalcArea();


            Assert.AreEqual(expected, result);
                
        }
    }
}