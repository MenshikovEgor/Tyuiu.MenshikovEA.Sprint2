using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint2.Task4.V6.Lib;

namespace Tyuiu.MenshikovEA.Sprint2.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 3;
            double y = 5;

            double z = ds.Calculate(x, y);
            Assert.AreEqual(z, 5.184);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            double x = 7;
            double y = 14;

            double z = ds.Calculate(x, y);
            Assert.AreEqual(z, 210.857);
        }
    }
}
