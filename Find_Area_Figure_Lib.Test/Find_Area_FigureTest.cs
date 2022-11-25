using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Find_Area_Figure_Lib.Test
{
    [TestClass]
    public class Find_Area_FigureTest
    {
        [TestMethod]
        public void find_area_circle()
        {
            int l = 8;

            double expected = 201.06192982974676;

            double actual =  Find_Area_Figure.find_area(l);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void find_area_triangle1()
        {
            int a = 8;
            int b = 6;
            int c = 10;

            double expected = 24;

            double actual = Find_Area_Figure.find_area(a,b,c);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void find_area_triangle2()
        {
            int a = 6;
            int b = 8;
            int c = 10;

            double expected = 24;

            double actual = Find_Area_Figure.find_area(a, b, c);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void find_area_triangle3()
        {
            int a = 8;
            int b = 10;
            int c = 6;

            double expected = 24;

            double actual = Find_Area_Figure.find_area(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }
}
