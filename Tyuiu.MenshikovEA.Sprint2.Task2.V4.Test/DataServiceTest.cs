using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint2.Task2.V4.Lib;

namespace Tyuiu.MenshikovEA.Sprint2.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 8;
            int y = 1;

            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(res, false);
        }
    }
}
